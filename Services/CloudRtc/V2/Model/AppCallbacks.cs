using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V2.Model
{
    /// <summary>
    /// app回调配置
    /// </summary>
    public class AppCallbacks 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("push_callback", NullValueHandling = NullValueHandling.Ignore)]
        public AppCallbackUrl PushCallback { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("record_callback", NullValueHandling = NullValueHandling.Ignore)]
        public AppCallbackUrl RecordCallback { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppCallbacks {\n");
            sb.Append("  pushCallback: ").Append(PushCallback).Append("\n");
            sb.Append("  recordCallback: ").Append(RecordCallback).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppCallbacks);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AppCallbacks input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PushCallback == input.PushCallback ||
                    (this.PushCallback != null &&
                    this.PushCallback.Equals(input.PushCallback))
                ) && 
                (
                    this.RecordCallback == input.RecordCallback ||
                    (this.RecordCallback != null &&
                    this.RecordCallback.Equals(input.RecordCallback))
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
                if (this.PushCallback != null)
                    hashCode = hashCode * 59 + this.PushCallback.GetHashCode();
                if (this.RecordCallback != null)
                    hashCode = hashCode * 59 + this.RecordCallback.GetHashCode();
                return hashCode;
            }
        }
    }
}
