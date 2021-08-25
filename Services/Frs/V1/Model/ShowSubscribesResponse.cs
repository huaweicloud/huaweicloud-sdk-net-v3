using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Frs.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowSubscribesResponse : SdkResponse
    {

        /// <summary>
        /// 调用成功时表示最大的人脸库数量。 调用失败时无此字段。
        /// </summary>
        [JsonProperty("max_face_set_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxFaceSetNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("detect_service", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceInfo DetectService { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("live_detect_service", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceInfo LiveDetectService { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("compare_service", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceInfo CompareService { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("search_service", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceInfo SearchService { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSubscribesResponse {\n");
            sb.Append("  maxFaceSetNumber: ").Append(MaxFaceSetNumber).Append("\n");
            sb.Append("  detectService: ").Append(DetectService).Append("\n");
            sb.Append("  liveDetectService: ").Append(LiveDetectService).Append("\n");
            sb.Append("  compareService: ").Append(CompareService).Append("\n");
            sb.Append("  searchService: ").Append(SearchService).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSubscribesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSubscribesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxFaceSetNumber == input.MaxFaceSetNumber ||
                    (this.MaxFaceSetNumber != null &&
                    this.MaxFaceSetNumber.Equals(input.MaxFaceSetNumber))
                ) && 
                (
                    this.DetectService == input.DetectService ||
                    (this.DetectService != null &&
                    this.DetectService.Equals(input.DetectService))
                ) && 
                (
                    this.LiveDetectService == input.LiveDetectService ||
                    (this.LiveDetectService != null &&
                    this.LiveDetectService.Equals(input.LiveDetectService))
                ) && 
                (
                    this.CompareService == input.CompareService ||
                    (this.CompareService != null &&
                    this.CompareService.Equals(input.CompareService))
                ) && 
                (
                    this.SearchService == input.SearchService ||
                    (this.SearchService != null &&
                    this.SearchService.Equals(input.SearchService))
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
                if (this.MaxFaceSetNumber != null)
                    hashCode = hashCode * 59 + this.MaxFaceSetNumber.GetHashCode();
                if (this.DetectService != null)
                    hashCode = hashCode * 59 + this.DetectService.GetHashCode();
                if (this.LiveDetectService != null)
                    hashCode = hashCode * 59 + this.LiveDetectService.GetHashCode();
                if (this.CompareService != null)
                    hashCode = hashCode * 59 + this.CompareService.GetHashCode();
                if (this.SearchService != null)
                    hashCode = hashCode * 59 + this.SearchService.GetHashCode();
                return hashCode;
            }
        }
    }
}
