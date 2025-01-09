using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 批量删除应用。
    /// </summary>
    public class BatchDeleteAppsReq 
    {

        /// <summary>
        /// 批量唯一标识请求列表，一次请求数量区间 [1, 50]。
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Items { get; set; }

        /// <summary>
        /// 是否保留OBS桶文件，如果不保留删除应用时，会同时删除OBS桶文件(默认false)。 * &#39;true&#39; - 保留OBS桶文件,不做任何操作。 * &#39;false&#39; - 不保留OBS桶文件,删除应用时同时删除OBS桶文件。
        /// </summary>
        [JsonProperty("reserve_obs_file", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReserveObsFile { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteAppsReq {\n");
            sb.Append("  items: ").Append(Items).Append("\n");
            sb.Append("  reserveObsFile: ").Append(ReserveObsFile).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteAppsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteAppsReq input)
        {
            if (input == null) return false;
            if (this.Items != input.Items || (this.Items != null && input.Items != null && !this.Items.SequenceEqual(input.Items))) return false;
            if (this.ReserveObsFile != input.ReserveObsFile || (this.ReserveObsFile != null && !this.ReserveObsFile.Equals(input.ReserveObsFile))) return false;

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
                if (this.Items != null) hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.ReserveObsFile != null) hashCode = hashCode * 59 + this.ReserveObsFile.GetHashCode();
                return hashCode;
            }
        }
    }
}
