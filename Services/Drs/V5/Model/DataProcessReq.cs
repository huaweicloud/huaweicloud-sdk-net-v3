using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 指定任务数据加工规则请求体
    /// </summary>
    public class DataProcessReq 
    {

        /// <summary>
        /// 指定任务数据加工规则请求体
        /// </summary>
        [JsonProperty("data_process_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataProcessInfo> DataProcessInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataProcessReq {\n");
            sb.Append("  dataProcessInfo: ").Append(DataProcessInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DataProcessReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DataProcessReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataProcessInfo == input.DataProcessInfo ||
                    this.DataProcessInfo != null &&
                    input.DataProcessInfo != null &&
                    this.DataProcessInfo.SequenceEqual(input.DataProcessInfo)
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
                if (this.DataProcessInfo != null)
                    hashCode = hashCode * 59 + this.DataProcessInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
