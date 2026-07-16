using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 训练作业日志输出信息。
    /// </summary>
    public class LogExportPath 
    {

        /// <summary>
        /// 训练作业日志保存的OBS地址，如：“obs://example/path”。
        /// </summary>
        [JsonProperty("obs_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsUrl { get; set; }

        /// <summary>
        /// 训练作业日志保存的宿主机的路径，如：“/example/path”。
        /// </summary>
        [JsonProperty("host_path", NullValueHandling = NullValueHandling.Ignore)]
        public string HostPath { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogExportPath {\n");
            sb.Append("  obsUrl: ").Append(ObsUrl).Append("\n");
            sb.Append("  hostPath: ").Append(HostPath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LogExportPath);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LogExportPath input)
        {
            if (input == null) return false;
            if (this.ObsUrl != input.ObsUrl || (this.ObsUrl != null && !this.ObsUrl.Equals(input.ObsUrl))) return false;
            if (this.HostPath != input.HostPath || (this.HostPath != null && !this.HostPath.Equals(input.HostPath))) return false;

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
                if (this.ObsUrl != null) hashCode = hashCode * 59 + this.ObsUrl.GetHashCode();
                if (this.HostPath != null) hashCode = hashCode * 59 + this.HostPath.GetHashCode();
                return hashCode;
            }
        }
    }
}
