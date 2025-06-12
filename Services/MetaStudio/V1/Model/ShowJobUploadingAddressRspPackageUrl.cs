using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 整包上传任务的url。
    /// </summary>
    public class ShowJobUploadingAddressRspPackageUrl 
    {

        /// <summary>
        /// 上传的训练数据地址,用户需要将训练数据打成zip包后上传到该url。 &gt; * 通过该obs地址上传时需要设置content-type为application/zip
        /// </summary>
        [JsonProperty("training_data_uploading_url", NullValueHandling = NullValueHandling.Ignore)]
        public string TrainingDataUploadingUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowJobUploadingAddressRspPackageUrl {\n");
            sb.Append("  trainingDataUploadingUrl: ").Append(TrainingDataUploadingUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowJobUploadingAddressRspPackageUrl);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowJobUploadingAddressRspPackageUrl input)
        {
            if (input == null) return false;
            if (this.TrainingDataUploadingUrl != input.TrainingDataUploadingUrl || (this.TrainingDataUploadingUrl != null && !this.TrainingDataUploadingUrl.Equals(input.TrainingDataUploadingUrl))) return false;

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
                if (this.TrainingDataUploadingUrl != null) hashCode = hashCode * 59 + this.TrainingDataUploadingUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
