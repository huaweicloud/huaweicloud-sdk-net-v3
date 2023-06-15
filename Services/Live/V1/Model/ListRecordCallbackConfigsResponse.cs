using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListRecordCallbackConfigsResponse : SdkResponse
    {

        /// <summary>
        /// 查询结果的总元素数量
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 回调配置
        /// </summary>
        [JsonProperty("callback_config", NullValueHandling = NullValueHandling.Ignore)]
        public List<RecordCallbackConfig> CallbackConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRecordCallbackConfigsResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  callbackConfig: ").Append(CallbackConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRecordCallbackConfigsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRecordCallbackConfigsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.CallbackConfig == input.CallbackConfig ||
                    this.CallbackConfig != null &&
                    input.CallbackConfig != null &&
                    this.CallbackConfig.SequenceEqual(input.CallbackConfig)
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.CallbackConfig != null)
                    hashCode = hashCode * 59 + this.CallbackConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
