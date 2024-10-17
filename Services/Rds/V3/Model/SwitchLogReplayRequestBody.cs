using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 中止/恢复wal日志回放请求体
    /// </summary>
    public class SwitchLogReplayRequestBody 
    {

        /// <summary>
        /// “true”表示中止回放，“false”表示恢复回放，其他情况表示不做操作
        /// </summary>
        [JsonProperty("pause_log_replay", NullValueHandling = NullValueHandling.Ignore)]
        public string PauseLogReplay { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwitchLogReplayRequestBody {\n");
            sb.Append("  pauseLogReplay: ").Append(PauseLogReplay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SwitchLogReplayRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SwitchLogReplayRequestBody input)
        {
            if (input == null) return false;
            if (this.PauseLogReplay != input.PauseLogReplay || (this.PauseLogReplay != null && !this.PauseLogReplay.Equals(input.PauseLogReplay))) return false;

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
                if (this.PauseLogReplay != null) hashCode = hashCode * 59 + this.PauseLogReplay.GetHashCode();
                return hashCode;
            }
        }
    }
}
