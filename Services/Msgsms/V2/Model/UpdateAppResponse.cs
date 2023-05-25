using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Msgsms.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateAppResponse : SdkResponse
    {

        /// <summary>
        /// 应用KEY
        /// </summary>
        [JsonProperty("app_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AppKey { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 应用主键ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAppResponse {\n");
            sb.Append("  appKey: ").Append(AppKey).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAppResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAppResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppKey == input.AppKey ||
                    (this.AppKey != null &&
                    this.AppKey.Equals(input.AppKey))
                ) && 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.AppKey != null)
                    hashCode = hashCode * 59 + this.AppKey.GetHashCode();
                if (this.AppName != null)
                    hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }
    }
}
