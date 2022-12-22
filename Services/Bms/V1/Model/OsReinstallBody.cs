using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// 重装裸金属服务器操作系统接口请求结构体
    /// </summary>
    public class OsReinstallBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("os-reinstall", NullValueHandling = NullValueHandling.Ignore)]
        public OsReinstall OsReinstall { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OsReinstallBody {\n");
            sb.Append("  osReinstall: ").Append(OsReinstall).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OsReinstallBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OsReinstallBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OsReinstall == input.OsReinstall ||
                    (this.OsReinstall != null &&
                    this.OsReinstall.Equals(input.OsReinstall))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.OsReinstall != null)
                    hashCode = hashCode * 59 + this.OsReinstall.GetHashCode();
                return hashCode;
            }
        }
    }
}
