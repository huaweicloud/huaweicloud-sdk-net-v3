using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteProductRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("Sp-Auth-Token", IsHeader = true)]
        [JsonProperty("Sp-Auth-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string SpAuthToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("Stage-Auth-Token", IsHeader = true)]
        [JsonProperty("Stage-Auth-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string StageAuthToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("Instance-Id", IsHeader = true)]
        [JsonProperty("Instance-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("product_id", IsPath = true)]
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("app_id", IsQuery = true)]
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteProductRequest {\n");
            sb.Append("  spAuthToken: ").Append(SpAuthToken).Append("\n");
            sb.Append("  stageAuthToken: ").Append(StageAuthToken).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteProductRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteProductRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SpAuthToken == input.SpAuthToken ||
                    (this.SpAuthToken != null &&
                    this.SpAuthToken.Equals(input.SpAuthToken))
                ) && 
                (
                    this.StageAuthToken == input.StageAuthToken ||
                    (this.StageAuthToken != null &&
                    this.StageAuthToken.Equals(input.StageAuthToken))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
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
                if (this.SpAuthToken != null)
                    hashCode = hashCode * 59 + this.SpAuthToken.GetHashCode();
                if (this.StageAuthToken != null)
                    hashCode = hashCode * 59 + this.StageAuthToken.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                return hashCode;
            }
        }
    }
}
