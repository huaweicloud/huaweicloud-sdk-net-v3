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
    /// Request Object
    /// </summary>
    public class DeleteAppRequest 
    {

        /// <summary>
        /// 应用ID。
        /// </summary>
        [SDKProperty("app_id", IsPath = true)]
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 删除应用时是否保留OBS桶文件(默认false) * &#39;true&#39; - 保留OBS桶文件,仅删除应用 * &#39;false&#39; - 不保留OBS桶文件,删除应用同时删除OBS桶文件
        /// </summary>
        [SDKProperty("reserve_obs_file", IsQuery = true)]
        [JsonProperty("reserve_obs_file", NullValueHandling = NullValueHandling.Ignore)]
        public string ReserveObsFile { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteAppRequest {\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  reserveObsFile: ").Append(ReserveObsFile).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteAppRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteAppRequest input)
        {
            if (input == null) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
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
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.ReserveObsFile != null) hashCode = hashCode * 59 + this.ReserveObsFile.GetHashCode();
                return hashCode;
            }
        }
    }
}
