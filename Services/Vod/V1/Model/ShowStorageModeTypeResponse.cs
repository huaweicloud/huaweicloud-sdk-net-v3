using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowStorageModeTypeResponse : SdkResponse
    {

        /// <summary>
        /// 降冷模式。 取值如下： - WHOLE：整个媒资粒度。 - ORIGIN：原文件粒度。 
        /// </summary>
        [JsonProperty("storage_mode_type", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageModeType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStorageModeTypeResponse {\n");
            sb.Append("  storageModeType: ").Append(StorageModeType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStorageModeTypeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStorageModeTypeResponse input)
        {
            if (input == null) return false;
            if (this.StorageModeType != input.StorageModeType || (this.StorageModeType != null && !this.StorageModeType.Equals(input.StorageModeType))) return false;

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
                if (this.StorageModeType != null) hashCode = hashCode * 59 + this.StorageModeType.GetHashCode();
                return hashCode;
            }
        }
    }
}
