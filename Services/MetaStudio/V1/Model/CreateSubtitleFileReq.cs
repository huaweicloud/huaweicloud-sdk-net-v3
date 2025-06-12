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
    /// 
    /// </summary>
    public class CreateSubtitleFileReq 
    {

        /// <summary>
        /// 剧本ID。
        /// </summary>
        [JsonProperty("script_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptId { get; set; }

        /// <summary>
        /// 剧本序号。  &gt; * 剧本序号不填生成所有场景的字幕；如果需要生成单场景的字幕，需要填剧本序号。
        /// </summary>
        [JsonProperty("sequence_no", NullValueHandling = NullValueHandling.Ignore)]
        public int? SequenceNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("callback_config", NullValueHandling = NullValueHandling.Ignore)]
        public CallBackConfig CallbackConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSubtitleFileReq {\n");
            sb.Append("  scriptId: ").Append(ScriptId).Append("\n");
            sb.Append("  sequenceNo: ").Append(SequenceNo).Append("\n");
            sb.Append("  callbackConfig: ").Append(CallbackConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSubtitleFileReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSubtitleFileReq input)
        {
            if (input == null) return false;
            if (this.ScriptId != input.ScriptId || (this.ScriptId != null && !this.ScriptId.Equals(input.ScriptId))) return false;
            if (this.SequenceNo != input.SequenceNo || (this.SequenceNo != null && !this.SequenceNo.Equals(input.SequenceNo))) return false;
            if (this.CallbackConfig != input.CallbackConfig || (this.CallbackConfig != null && !this.CallbackConfig.Equals(input.CallbackConfig))) return false;

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
                if (this.ScriptId != null) hashCode = hashCode * 59 + this.ScriptId.GetHashCode();
                if (this.SequenceNo != null) hashCode = hashCode * 59 + this.SequenceNo.GetHashCode();
                if (this.CallbackConfig != null) hashCode = hashCode * 59 + this.CallbackConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
