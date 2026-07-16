using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchUnBindApiKeyRequest : IFormDataBody
    {

        /// <summary>
        /// **参数解释：** 请求批量解绑的api-key的id数组。 **约束限制：** 请求批量解绑api-key的id个数不超过10个。
        /// </summary>
        [JsonProperty("key_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchUnBindApiKeyRequestKeyIds> KeyIds { get; set; }


        

        public Dictionary<string, object> BuildFormData()
        {
            var formData = new Dictionary<string, object>();

            formData.Add("key_ids", new FormDataPart<List<BatchUnBindApiKeyRequestKeyIds>>(KeyIds));

            return formData;
        }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUnBindApiKeyRequest {\n");
            sb.Append("  keyIds: ").Append(KeyIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUnBindApiKeyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUnBindApiKeyRequest input)
        {
            if (input == null) return false;
            if (this.KeyIds != input.KeyIds || (this.KeyIds != null && input.KeyIds != null && !this.KeyIds.SequenceEqual(input.KeyIds))) return false;

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
                if (this.KeyIds != null) hashCode = hashCode * 59 + this.KeyIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
