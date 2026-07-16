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
    /// 远程接入训练作业时需要的相关配置。
    /// </summary>
    public class JobEndpointsResp 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ssh", NullValueHandling = NullValueHandling.Ignore)]
        public SSHResp Ssh { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("jupyter_lab", NullValueHandling = NullValueHandling.Ignore)]
        public JupyterLab JupyterLab { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tensorboard", NullValueHandling = NullValueHandling.Ignore)]
        public Tensorboard Tensorboard { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mindstudio_insight", NullValueHandling = NullValueHandling.Ignore)]
        public MindStudioInsight MindstudioInsight { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobEndpointsResp {\n");
            sb.Append("  ssh: ").Append(Ssh).Append("\n");
            sb.Append("  jupyterLab: ").Append(JupyterLab).Append("\n");
            sb.Append("  tensorboard: ").Append(Tensorboard).Append("\n");
            sb.Append("  mindstudioInsight: ").Append(MindstudioInsight).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobEndpointsResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobEndpointsResp input)
        {
            if (input == null) return false;
            if (this.Ssh != input.Ssh || (this.Ssh != null && !this.Ssh.Equals(input.Ssh))) return false;
            if (this.JupyterLab != input.JupyterLab || (this.JupyterLab != null && !this.JupyterLab.Equals(input.JupyterLab))) return false;
            if (this.Tensorboard != input.Tensorboard || (this.Tensorboard != null && !this.Tensorboard.Equals(input.Tensorboard))) return false;
            if (this.MindstudioInsight != input.MindstudioInsight || (this.MindstudioInsight != null && !this.MindstudioInsight.Equals(input.MindstudioInsight))) return false;

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
                if (this.Ssh != null) hashCode = hashCode * 59 + this.Ssh.GetHashCode();
                if (this.JupyterLab != null) hashCode = hashCode * 59 + this.JupyterLab.GetHashCode();
                if (this.Tensorboard != null) hashCode = hashCode * 59 + this.Tensorboard.GetHashCode();
                if (this.MindstudioInsight != null) hashCode = hashCode * 59 + this.MindstudioInsight.GetHashCode();
                return hashCode;
            }
        }
    }
}
