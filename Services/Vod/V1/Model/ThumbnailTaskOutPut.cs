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
    public class ThumbnailTaskOutPut 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("obs_info", NullValueHandling = NullValueHandling.Ignore)]
        public ObsInfo ObsInfo { get; set; }

        /// <summary>
        /// 截图信息列表
        /// </summary>
        [JsonProperty("pic_info_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<PicInfo> PicInfoList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThumbnailTaskOutPut {\n");
            sb.Append("  obsInfo: ").Append(ObsInfo).Append("\n");
            sb.Append("  picInfoList: ").Append(PicInfoList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ThumbnailTaskOutPut);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ThumbnailTaskOutPut input)
        {
            if (input == null) return false;
            if (this.ObsInfo != input.ObsInfo || (this.ObsInfo != null && !this.ObsInfo.Equals(input.ObsInfo))) return false;
            if (this.PicInfoList != input.PicInfoList || (this.PicInfoList != null && input.PicInfoList != null && !this.PicInfoList.SequenceEqual(input.PicInfoList))) return false;

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
                if (this.ObsInfo != null) hashCode = hashCode * 59 + this.ObsInfo.GetHashCode();
                if (this.PicInfoList != null) hashCode = hashCode * 59 + this.PicInfoList.GetHashCode();
                return hashCode;
            }
        }
    }
}
