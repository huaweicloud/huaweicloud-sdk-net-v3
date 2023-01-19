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
    /// 
    /// </summary>
    public class UploadMetaDataByUrlReq 
    {

        /// <summary>
        /// 待拉取创建的媒资元数据
        /// </summary>
        [JsonProperty("upload_metadatas", NullValueHandling = NullValueHandling.Ignore)]
        public List<UploadMetaDataByUrl> UploadMetadatas { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadMetaDataByUrlReq {\n");
            sb.Append("  uploadMetadatas: ").Append(UploadMetadatas).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UploadMetaDataByUrlReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UploadMetaDataByUrlReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UploadMetadatas == input.UploadMetadatas ||
                    this.UploadMetadatas != null &&
                    input.UploadMetadatas != null &&
                    this.UploadMetadatas.SequenceEqual(input.UploadMetadatas)
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
                if (this.UploadMetadatas != null)
                    hashCode = hashCode * 59 + this.UploadMetadatas.GetHashCode();
                return hashCode;
            }
        }
    }
}
