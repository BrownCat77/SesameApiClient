using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using SesameApiClient.Entities;
using SesameApiClient.Exceptions;
using SesameApiClient.Http;
using SesameApiClient.Models;
using SesameApiClient.Utils;

namespace SesameApiClient
{
    public partial class MainForm : Form
    {
        private List<DeviceEntity> device_list;

        public MainForm()
        {
            InitializeComponent();

            SetDefaultConnection();
            RefreshDeviceList();
            SwitchEnabled();
        }

        private ConnectionEntity GetConnectionInfo()
        {
            return new ConnectionEntity()
            {
                BaseUrl = tbSesameApiUrl.Text,
                Token = tbSesameToken.Text,
            };
        }

        #region [-]Update Form
        private void SetDefaultConnection()
        {
            tbSesameApiUrl.Text = ExternalParameter.DefaultSesameApiURL;
            tbSesameToken.Text = ExternalParameter.DefaultSesameToken;
        }

        private void RefreshDeviceList(string selected_device_id = "")
        {
            lbDeviceList.Items.Clear();

            if (device_list == null)
                return;

            lbDeviceList.Items.AddRange(device_list.ToArray());

            var selected_device = lbDeviceList.Items.Cast<DeviceEntity>().Where(p => p.device_id == selected_device_id).FirstOrDefault();
            if (selected_device != null)
                lbDeviceList.SelectedItem = selected_device;
        }


        private void RefreshDeviceInfo(DeviceEntity device_info = null)
        {
            tbDeviceId.Text = string.Empty;
            tbSerialNo.Text = string.Empty;
            tbNickName.Text = string.Empty;

            cbLocked.Checked = false;
            tbBattery.Text = string.Empty;
            cbResponsive.Checked = false;

            lbTaskHistory.Items.Clear();

            if (device_info == null)
                return;

            tbDeviceId.Text = device_info.device_id;
            tbSerialNo.Text = device_info.serial;
            tbNickName.Text = device_info.nickname;

            cbLocked.Checked = device_info.locked;
            tbBattery.Text = device_info.battery.ToString();
            cbResponsive.Checked = device_info.responsive;

            lbTaskHistory.Items.AddRange(device_info.task_list.ToArray());
        }

        private void RefreshTaskInfo(TaskEntity task_info = null)
        {
            tbTaskId.Text = string.Empty;
            tbTaskCommand.Text = string.Empty;
            tbTaskDateTime.Text = string.Empty;

            tbTaskStatus.Text = string.Empty;
            cbTaskSuccessful.Checked = false;
            tbTaskError.Text = string.Empty;

            if (task_info == null)
                return;

            tbTaskId.Text = task_info.task_id;
            tbTaskCommand.Text = task_info.command;
            tbTaskDateTime.Text = task_info.execution_date.ToString();

            if (!task_info.has_result)
                return;

            tbTaskStatus.Text = task_info.status;
            cbTaskSuccessful.Checked = task_info.successful;
            tbTaskError.Text = task_info.error;
        }

        private void SwitchEnabled()
        {
            //★☆ まず全て無効化
            lbDeviceList.Enabled = false;
            btnGetDeviceList.Enabled = false;
            btnGetDeviceStatus.Enabled = false;
            btnControlLock.Enabled = false;
            btnControlUnlock.Enabled = false;
            btnControlSync.Enabled = false;
            btnQueryTaskResult.Enabled = false;


            //★☆ デバイスリストのみ初期状態で有効
            lbDeviceList.Enabled = true;
            btnGetDeviceList.Enabled = true;

            var selected_device = lbDeviceList.SelectedItem;
            if (selected_device == null)
                return;

            //★☆ デバイスが選択されている場合は以下を処理
            btnGetDeviceStatus.Enabled = true;
            btnControlLock.Enabled = true;
            btnControlUnlock.Enabled = true;
            btnControlSync.Enabled = true;

            //★☆ タスクが選択されている場合は以下を処理
            var selected_task = lbTaskHistory.SelectedItem;
            if (selected_task == null)
                return;

            btnQueryTaskResult.Enabled = true;
        }

        private void ClearInformationField()
        {
            tbInformation.Clear();
            tbInformation.BackColor = Color.FromName("Control");
        }

        private void SetSuccessColor()
        {
            tbInformation.BackColor = Color.LightGreen;
        }

        private void SetWarningColor()
        {
            tbInformation.BackColor = Color.Yellow;
        }

        private void SetFailureColor()
        {
            tbInformation.BackColor = Color.LightCoral;
        }
        #endregion

        #region [-]Show Message
        private string CreateSuccessMessage(string add_msg)
        {
            string ret = String.Empty;
            ret += ("【Success】" + Environment.NewLine);
            ret += (add_msg + Environment.NewLine);
            return ret;
        }

        private string CreateNetworkErrorMessage(string msg)
        {
            string ret = String.Empty;
            ret += ("【Network Error】" + Environment.NewLine);
            ret += (msg + Environment.NewLine);
            return ret;
        }
        #endregion


        #region [-]Send Request
        private void SendRequest_GetDeviceList()
        {
            var connection = GetConnectionInfo();
            var req = new HttpRequest_GetSesameList(connection);

            string body_str;
            bool result = req.SendRequest(out body_str);
            if (!result)
                throw new ServerAccessException(body_str);

            var model = JsonConverter.ParseSesameListResponse(body_str);
            SetDeviceList(model);

            RefreshDeviceList();
            SwitchEnabled();

            tbInformation.Text += CreateSuccessMessage("Get Device List!");
        }

        private void SendRequest_GetDeviceStatus()
        {
            var connection = GetConnectionInfo();
            var req = new HttpRequest_GetSesameStatus(connection);

            var target_device_id = tbDeviceId.Text;
            req.SetDeviceId(target_device_id);

            string body_str;
            bool result = req.SendRequest(out body_str);
            if (!result)
                throw new ServerAccessException(body_str);

            var model = JsonConverter.ParseSesameStatusResponse(body_str);
            SetDeviceStatus(model);

            var target_device = (DeviceEntity)lbDeviceList.SelectedItem;
            RefreshDeviceInfo(target_device);

            SwitchEnabled();

            tbInformation.Text += CreateSuccessMessage("Get Device Status!");
        }

        private void SendRequest_ControlDeviceLock()
        {
            SendRequest_ControlDevice(CommandType.@lock);
        }

        private void SendRequest_ControlDeviceUnlock()
        {
            SendRequest_ControlDevice(CommandType.unlock);
        }

        private void SendRequest_ControlDeviceSync()
        {
            SendRequest_ControlDevice(CommandType.sync);
        }

        private void SendRequest_ControlDevice(CommandType command)
        {
            var connection = GetConnectionInfo();
            var req = new HttpRequest_ControlSesame(connection);

            var target_device_id = tbDeviceId.Text;
            req.SetDeviceId(target_device_id);
            req.SetParam(command.ToString());

            string body_str;
            bool result = req.SendRequest(out body_str);
            if (!result)
                throw new ServerAccessException(body_str);

            var model = JsonConverter.ParseSesameControlResponse(body_str);
            SetTaskList(model, command);

            var target_device = (DeviceEntity)lbDeviceList.SelectedItem;
            RefreshDeviceInfo(target_device);

            var target_task = (TaskEntity)lbTaskHistory.SelectedItem;
            RefreshTaskInfo(target_task);

            SwitchEnabled();

            var msg = string.Format("Request Device [{0}]!", command);
            tbInformation.Text += CreateSuccessMessage(msg);
        }

        private void SendRequest_QueryExecutionResult()
        {
            var connection = GetConnectionInfo();
            var req = new HttpRequest_QueryExecutionResult(connection);

            var target_task_id = tbTaskId.Text;
            req.SetParam(target_task_id);

            string body_str;
            bool result = req.SendRequest(out body_str);
            if (!result)
                throw new ServerAccessException(body_str);

            var model = JsonConverter.ParseSesameTaskQueryResponse(body_str);
            SetTaskStatus(model);

            var target_task = (TaskEntity)lbTaskHistory.SelectedItem;
            RefreshTaskInfo(target_task);

            SwitchEnabled();

            tbInformation.Text += CreateSuccessMessage("Get Execution Result!");
        }
        #endregion

        #region [-]Set Response Data
        private void SetDeviceList(List<SesameBaseResponseModel> list)
        {
            if (list == null)
                return;

            device_list = list.Select(p => new DeviceEntity
            {
                device_id = p.device_id,
                serial = p.serial,
                nickname = p.nickname,
            }).ToList();
        }

        private void SetDeviceStatus(SesameStatusResponseModel data)
        {
            if (lbDeviceList.SelectedItem == null)
                return;

            var selected_device = (DeviceEntity)lbDeviceList.SelectedItem;
            var target_device = device_list.FirstOrDefault(p => p.device_id == selected_device.device_id);
            if (target_device == null)
                return;

            target_device.has_status = true;
            target_device.locked = data.locked;
            target_device.battery = data.battery;
            target_device.responsive = data.responsive;
        }

        private void SetTaskList(SesameControlResponseModel data, CommandType command)
        {
            if (lbDeviceList.SelectedItem == null)
                return;

            var selected_device = (DeviceEntity)lbDeviceList.SelectedItem;
            var target_device = device_list.FirstOrDefault(p => p.device_id == selected_device.device_id);
            if (target_device == null)
                return;

            var task = new TaskEntity
            {
                task_id = data.task_id,
                command = command.ToString(),
                execution_date = ProjectUtility.GetNow(),
            };
            target_device.AddTask(task);
        }

        private void SetTaskStatus(SesameTaskResponseModel data)
        {
            if (lbTaskHistory.SelectedItem == null)
                return;

            var selected_task = (TaskEntity)lbTaskHistory.SelectedItem;
            selected_task.has_result = true;
            selected_task.status = data.status;
            selected_task.successful = data.successful;
            selected_task.error = data.error;
        }
        #endregion


        #region [-]Event Handler
        private void lbDeviceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = (ListBox)sender;

            var target_device = (DeviceEntity)obj.SelectedItem;
            RefreshDeviceInfo(target_device);
            RefreshTaskInfo();

            SwitchEnabled();
        }

        private void lbTaskHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = (ListBox)sender;

            var target_task = (TaskEntity)obj.SelectedItem;
            RefreshTaskInfo(target_task);

            SwitchEnabled();
        }

        private void btnGetDeviceList_Click(object sender, EventArgs e)
        {
            ExecuteProcess(SendRequest_GetDeviceList);
        }

        private void btnGetDeviceStatus_Click(object sender, EventArgs e)
        {
            ExecuteProcess(SendRequest_GetDeviceStatus);
        }

        private void btnControlLock_Click(object sender, EventArgs e)
        {
            ExecuteProcess(SendRequest_ControlDeviceLock);
        }

        private void btnControlUnlock_Click(object sender, EventArgs e)
        {
            ExecuteProcess(SendRequest_ControlDeviceUnlock);
        }

        private void btnControlSync_Click(object sender, EventArgs e)
        {
            ExecuteProcess(SendRequest_ControlDeviceSync);
        }

        private void btnQueryTaskResult_Click(object sender, EventArgs e)
        {
            ExecuteProcess(SendRequest_QueryExecutionResult);
        }

        private void ExecuteProcess(Action process)
        {
            ClearInformationField();
            try
            {
                process();
                SetSuccessColor();
            }
            catch (ServerAccessException ex)
            {
                tbInformation.Text = CreateNetworkErrorMessage(ex.Message);
                SetFailureColor();
            }
        }
        #endregion
    }
}
