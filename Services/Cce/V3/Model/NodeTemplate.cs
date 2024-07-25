using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NodeTemplate 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("os", NullValueHandling = NullValueHandling.Ignore)]
        public string Os { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("imageID", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("login", NullValueHandling = NullValueHandling.Ignore)]
        public NodeTemplateLogin Login { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lifeCycle", NullValueHandling = NullValueHandling.Ignore)]
        public NodeTemplateLifeCycle LifeCycle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("runtimeConfig", NullValueHandling = NullValueHandling.Ignore)]
        public NodeTemplateRuntimeConfig RuntimeConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extendParam", NullValueHandling = NullValueHandling.Ignore)]
        public NodeTemplateExtendParam ExtendParam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeTemplate {\n");
            sb.Append("  os: ").Append(Os).Append("\n");
            sb.Append("  imageID: ").Append(ImageID).Append("\n");
            sb.Append("  login: ").Append(Login).Append("\n");
            sb.Append("  lifeCycle: ").Append(LifeCycle).Append("\n");
            sb.Append("  runtimeConfig: ").Append(RuntimeConfig).Append("\n");
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeTemplate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeTemplate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Os == input.Os ||
                    (this.Os != null &&
                    this.Os.Equals(input.Os))
                ) && 
                (
                    this.ImageID == input.ImageID ||
                    (this.ImageID != null &&
                    this.ImageID.Equals(input.ImageID))
                ) && 
                (
                    this.Login == input.Login ||
                    (this.Login != null &&
                    this.Login.Equals(input.Login))
                ) && 
                (
                    this.LifeCycle == input.LifeCycle ||
                    (this.LifeCycle != null &&
                    this.LifeCycle.Equals(input.LifeCycle))
                ) && 
                (
                    this.RuntimeConfig == input.RuntimeConfig ||
                    (this.RuntimeConfig != null &&
                    this.RuntimeConfig.Equals(input.RuntimeConfig))
                ) && 
                (
                    this.ExtendParam == input.ExtendParam ||
                    (this.ExtendParam != null &&
                    this.ExtendParam.Equals(input.ExtendParam))
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
                if (this.Os != null)
                    hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.ImageID != null)
                    hashCode = hashCode * 59 + this.ImageID.GetHashCode();
                if (this.Login != null)
                    hashCode = hashCode * 59 + this.Login.GetHashCode();
                if (this.LifeCycle != null)
                    hashCode = hashCode * 59 + this.LifeCycle.GetHashCode();
                if (this.RuntimeConfig != null)
                    hashCode = hashCode * 59 + this.RuntimeConfig.GetHashCode();
                if (this.ExtendParam != null)
                    hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
