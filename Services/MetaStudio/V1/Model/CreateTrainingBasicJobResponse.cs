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
    /// Response Object
    /// </summary>
    public class CreateTrainingBasicJobResponse : SdkResponse
    {

        /// <summary>
        /// 任务id。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 上传训练数据的地址。训练数据需打包成zip文件后，上传至该url。  create_type取值为package时设置。 &gt; 通过该obs地址上传时，需设置content-type为application/zip。
        /// </summary>
        [JsonProperty("training_data_uploading_url", NullValueHandling = NullValueHandling.Ignore)]
        public string TrainingDataUploadingUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("segment_uploading_url", NullValueHandling = NullValueHandling.Ignore)]
        public CreateTrainingJobRspSegmentUploadingUrl SegmentUploadingUrl { get; set; }

        /// <summary>
        /// 授权书的上传地址。
        /// </summary>
        [JsonProperty("authorization_letter_uploading_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizationLetterUploadingUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTrainingBasicJobResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  trainingDataUploadingUrl: ").Append(TrainingDataUploadingUrl).Append("\n");
            sb.Append("  segmentUploadingUrl: ").Append(SegmentUploadingUrl).Append("\n");
            sb.Append("  authorizationLetterUploadingUrl: ").Append(AuthorizationLetterUploadingUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTrainingBasicJobResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTrainingBasicJobResponse input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.TrainingDataUploadingUrl != input.TrainingDataUploadingUrl || (this.TrainingDataUploadingUrl != null && !this.TrainingDataUploadingUrl.Equals(input.TrainingDataUploadingUrl))) return false;
            if (this.SegmentUploadingUrl != input.SegmentUploadingUrl || (this.SegmentUploadingUrl != null && !this.SegmentUploadingUrl.Equals(input.SegmentUploadingUrl))) return false;
            if (this.AuthorizationLetterUploadingUrl != input.AuthorizationLetterUploadingUrl || (this.AuthorizationLetterUploadingUrl != null && !this.AuthorizationLetterUploadingUrl.Equals(input.AuthorizationLetterUploadingUrl))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.TrainingDataUploadingUrl != null) hashCode = hashCode * 59 + this.TrainingDataUploadingUrl.GetHashCode();
                if (this.SegmentUploadingUrl != null) hashCode = hashCode * 59 + this.SegmentUploadingUrl.GetHashCode();
                if (this.AuthorizationLetterUploadingUrl != null) hashCode = hashCode * 59 + this.AuthorizationLetterUploadingUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
