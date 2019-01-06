using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SesameApiClient.Utils
{
    public class ProjectUtility
    {
        public const string ContentTypeJson = "application/json";

        #region Utility
        public static DateTime GetNow()
        {
            //今回はローカルタイムで
            return DateTime.Now;
            //return DateTime.UtcNow;
        }

        /// <summary>
        ///   引数で受け取った文字列を/でつなげてURLにする
        /// </summary>
        public static string CreateUrlString(params string[] values)
        {
            return ConcatWithSeparator(values, "/");
        }

        public static string CreatePathString(params string[] values)
        {
            return ConcatWithSeparator(values, @"\");
        }

        private static string ConcatWithSeparator(string[] values, string separator)
        {
            //最後尾のseparatorを削除し、かつ空データの場合は除外する
            var tmp = values.Select(p => p.TrimEnd(separator.ToCharArray()));
            tmp = tmp.Where(p => p != null && !String.IsNullOrWhiteSpace(p));

            //separatorで各文字列を結合して返す
            return String.Join(separator, tmp.ToArray());
        }
        #endregion
    }

    public enum CommandType
    {
        @lock,
        unlock,
        sync,
        unknown,
    }
}
