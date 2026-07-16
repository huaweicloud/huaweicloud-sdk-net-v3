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
    /// 可视化作业或训练作业调试模式的可视化日志输入，训练作业高级功能开启\&quot;tensorboard/enable\&quot;: \&quot;true\&quot;或\&quot;mindstudio-insight/enable\&quot;: \&quot;true\&quot;时必填。
    /// </summary>
    public class DataSource 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("job", NullValueHandling = NullValueHandling.Ignore)]
        public JobSummary Job { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nfs", NullValueHandling = NullValueHandling.Ignore)]
        public NFSSummary Nfs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataSource {\n");
            sb.Append("  job: ").Append(Job).Append("\n");
            sb.Append("  nfs: ").Append(Nfs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DataSource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DataSource input)
        {
            if (input == null) return false;
            if (this.Job != input.Job || (this.Job != null && !this.Job.Equals(input.Job))) return false;
            if (this.Nfs != input.Nfs || (this.Nfs != null && !this.Nfs.Equals(input.Nfs))) return false;

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
                if (this.Job != null) hashCode = hashCode * 59 + this.Job.GetHashCode();
                if (this.Nfs != null) hashCode = hashCode * 59 + this.Nfs.GetHashCode();
                return hashCode;
            }
        }
    }
}
