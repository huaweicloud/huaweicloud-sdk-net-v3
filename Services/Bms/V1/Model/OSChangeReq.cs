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
    /// 切换裸金属服务器操作系统接口请求结构体
    /// </summary>
    public class OSChangeReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("os-change", NullValueHandling = NullValueHandling.Ignore)]
        public OsChange OsChange { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OSChangeReq {\n");
            sb.Append("  osChange: ").Append(OsChange).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OSChangeReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OSChangeReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OsChange == input.OsChange ||
                    (this.OsChange != null &&
                    this.OsChange.Equals(input.OsChange))
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
                if (this.OsChange != null)
                    hashCode = hashCode * 59 + this.OsChange.GetHashCode();
                return hashCode;
            }
        }
    }
}
