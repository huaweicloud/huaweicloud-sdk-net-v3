using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 重定向和发送文件共同控制项。
    /// </summary>
    public class PoliciesFileAndClipboardFileRedirectionRedirectionSendFileOptions 
    {

        /// <summary>
        /// 读写速度（Kbps）。取值范围为[0-2147483647]。默认：0。
        /// </summary>
        [JsonProperty("read_write_speed", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReadWriteSpeed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesFileAndClipboardFileRedirectionRedirectionSendFileOptions {\n");
            sb.Append("  readWriteSpeed: ").Append(ReadWriteSpeed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesFileAndClipboardFileRedirectionRedirectionSendFileOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesFileAndClipboardFileRedirectionRedirectionSendFileOptions input)
        {
            if (input == null) return false;
            if (this.ReadWriteSpeed != input.ReadWriteSpeed || (this.ReadWriteSpeed != null && !this.ReadWriteSpeed.Equals(input.ReadWriteSpeed))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.ReadWriteSpeed != null) hashCode = hashCode * 59 + this.ReadWriteSpeed.GetHashCode();
                return hashCode;
            }
        }
    }
}
