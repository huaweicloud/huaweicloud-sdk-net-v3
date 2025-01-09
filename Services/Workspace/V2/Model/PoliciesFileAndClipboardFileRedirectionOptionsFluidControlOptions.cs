using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 流控控制项。
    /// </summary>
    public class PoliciesFileAndClipboardFileRedirectionOptionsFluidControlOptions 
    {

        /// <summary>
        /// 网络优的延时阈值（ms）。取值范围为[1-1000]。默认：30。
        /// </summary>
        [JsonProperty("good_network_latency", NullValueHandling = NullValueHandling.Ignore)]
        public int? GoodNetworkLatency { get; set; }

        /// <summary>
        /// 网络一般的延时阈值（ms）。取值范围为[1-1000]。默认：70。
        /// </summary>
        [JsonProperty("normal_network_latency", NullValueHandling = NullValueHandling.Ignore)]
        public int? NormalNetworkLatency { get; set; }

        /// <summary>
        /// 网络差的延时阈值（ms）。取值范围为[1-1000]。默认：100。
        /// </summary>
        [JsonProperty("poor_network_latency", NullValueHandling = NullValueHandling.Ignore)]
        public int? PoorNetworkLatency { get; set; }

        /// <summary>
        /// 降速步伐（KB）。取值范围为[1-100]。默认：20。
        /// </summary>
        [JsonProperty("reducing_step", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReducingStep { get; set; }

        /// <summary>
        /// 慢增速步伐（KB）。取值范围为[1-100]。默认：10。
        /// </summary>
        [JsonProperty("slow_increasing_step", NullValueHandling = NullValueHandling.Ignore)]
        public int? SlowIncreasingStep { get; set; }

        /// <summary>
        /// 快增速步伐（KB）。取值范围为[1-100]。默认：20。
        /// </summary>
        [JsonProperty("quick_increasing_step", NullValueHandling = NullValueHandling.Ignore)]
        public int? QuickIncreasingStep { get; set; }

        /// <summary>
        /// 传输初始速度（KB/s）。取值范围为[1-10240]。默认：1024。
        /// </summary>
        [JsonProperty("start_speed", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartSpeed { get; set; }

        /// <summary>
        /// 测速块大小（KB）。取值范围为[64-1024]。默认：64。
        /// </summary>
        [JsonProperty("test_block_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestBlockSize { get; set; }

        /// <summary>
        /// 测速块时间间隔（ms）。取值范围为[1000-100000]。默认：10000。
        /// </summary>
        [JsonProperty("test_time_gap", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestTimeGap { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesFileAndClipboardFileRedirectionOptionsFluidControlOptions {\n");
            sb.Append("  goodNetworkLatency: ").Append(GoodNetworkLatency).Append("\n");
            sb.Append("  normalNetworkLatency: ").Append(NormalNetworkLatency).Append("\n");
            sb.Append("  poorNetworkLatency: ").Append(PoorNetworkLatency).Append("\n");
            sb.Append("  reducingStep: ").Append(ReducingStep).Append("\n");
            sb.Append("  slowIncreasingStep: ").Append(SlowIncreasingStep).Append("\n");
            sb.Append("  quickIncreasingStep: ").Append(QuickIncreasingStep).Append("\n");
            sb.Append("  startSpeed: ").Append(StartSpeed).Append("\n");
            sb.Append("  testBlockSize: ").Append(TestBlockSize).Append("\n");
            sb.Append("  testTimeGap: ").Append(TestTimeGap).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesFileAndClipboardFileRedirectionOptionsFluidControlOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesFileAndClipboardFileRedirectionOptionsFluidControlOptions input)
        {
            if (input == null) return false;
            if (this.GoodNetworkLatency != input.GoodNetworkLatency || (this.GoodNetworkLatency != null && !this.GoodNetworkLatency.Equals(input.GoodNetworkLatency))) return false;
            if (this.NormalNetworkLatency != input.NormalNetworkLatency || (this.NormalNetworkLatency != null && !this.NormalNetworkLatency.Equals(input.NormalNetworkLatency))) return false;
            if (this.PoorNetworkLatency != input.PoorNetworkLatency || (this.PoorNetworkLatency != null && !this.PoorNetworkLatency.Equals(input.PoorNetworkLatency))) return false;
            if (this.ReducingStep != input.ReducingStep || (this.ReducingStep != null && !this.ReducingStep.Equals(input.ReducingStep))) return false;
            if (this.SlowIncreasingStep != input.SlowIncreasingStep || (this.SlowIncreasingStep != null && !this.SlowIncreasingStep.Equals(input.SlowIncreasingStep))) return false;
            if (this.QuickIncreasingStep != input.QuickIncreasingStep || (this.QuickIncreasingStep != null && !this.QuickIncreasingStep.Equals(input.QuickIncreasingStep))) return false;
            if (this.StartSpeed != input.StartSpeed || (this.StartSpeed != null && !this.StartSpeed.Equals(input.StartSpeed))) return false;
            if (this.TestBlockSize != input.TestBlockSize || (this.TestBlockSize != null && !this.TestBlockSize.Equals(input.TestBlockSize))) return false;
            if (this.TestTimeGap != input.TestTimeGap || (this.TestTimeGap != null && !this.TestTimeGap.Equals(input.TestTimeGap))) return false;

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
                if (this.GoodNetworkLatency != null) hashCode = hashCode * 59 + this.GoodNetworkLatency.GetHashCode();
                if (this.NormalNetworkLatency != null) hashCode = hashCode * 59 + this.NormalNetworkLatency.GetHashCode();
                if (this.PoorNetworkLatency != null) hashCode = hashCode * 59 + this.PoorNetworkLatency.GetHashCode();
                if (this.ReducingStep != null) hashCode = hashCode * 59 + this.ReducingStep.GetHashCode();
                if (this.SlowIncreasingStep != null) hashCode = hashCode * 59 + this.SlowIncreasingStep.GetHashCode();
                if (this.QuickIncreasingStep != null) hashCode = hashCode * 59 + this.QuickIncreasingStep.GetHashCode();
                if (this.StartSpeed != null) hashCode = hashCode * 59 + this.StartSpeed.GetHashCode();
                if (this.TestBlockSize != null) hashCode = hashCode * 59 + this.TestBlockSize.GetHashCode();
                if (this.TestTimeGap != null) hashCode = hashCode * 59 + this.TestTimeGap.GetHashCode();
                return hashCode;
            }
        }
    }
}
