using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// GaussDB(for openGauss)实例版本升级接口传参参数。
    /// </summary>
    public class OpenGaussUpgradeRequest 
    {

        /// <summary>
        /// 实例升级类型，包括就地升级，灰度升级，热补丁升级三种，三种升级方式的异同，详见接口描述。  inplace 就地升级  grey 灰度升级  hotfix 热补丁升级。
        /// </summary>
        [JsonProperty("upgrade_type", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradeType { get; set; }

        /// <summary>
        /// 实例升级操作，就地升级无需传值。灰度升级包括升级自动提交，升级待观察，提交升级，升级回退四种。热补丁升级包括升级自动提交，升级回退两种。详见接口描述。  upgradeAutoCommit 升级自动提交  upgrade 升级待观察  commit 提交升级  rollback 升级回退。
        /// </summary>
        [JsonProperty("upgrade_action", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradeAction { get; set; }

        /// <summary>
        /// 实例升级目标版本，非必填。如果未传值则默认升级到当前实例的优选版本。仅热补丁升级方式下支持传入多个值，升级操作为升级自动提交，则实例版本从小到大批量升级，升级操作为升级回退，则实例版本从大到小批量回退。
        /// </summary>
        [JsonProperty("target_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// 分布式实例灰度升级，滚动升级分片数。分布式实例灰度升级，升级待观察必填。该值不能大于实例未升级分片总数。
        /// </summary>
        [JsonProperty("upgrade_shard_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? UpgradeShardNum { get; set; }

        /// <summary>
        /// 主备版实例灰度升级，滚动升级az值，可以支持多az一起升级，az之间以’,’分割。集中式实例灰度升级，升级待观察必填。该值不能填入不属于该实例的az值。
        /// </summary>
        [JsonProperty("upgrade_az", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradeAz { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenGaussUpgradeRequest {\n");
            sb.Append("  upgradeType: ").Append(UpgradeType).Append("\n");
            sb.Append("  upgradeAction: ").Append(UpgradeAction).Append("\n");
            sb.Append("  targetVersion: ").Append(TargetVersion).Append("\n");
            sb.Append("  upgradeShardNum: ").Append(UpgradeShardNum).Append("\n");
            sb.Append("  upgradeAz: ").Append(UpgradeAz).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpenGaussUpgradeRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OpenGaussUpgradeRequest input)
        {
            if (input == null) return false;
            if (this.UpgradeType != input.UpgradeType || (this.UpgradeType != null && !this.UpgradeType.Equals(input.UpgradeType))) return false;
            if (this.UpgradeAction != input.UpgradeAction || (this.UpgradeAction != null && !this.UpgradeAction.Equals(input.UpgradeAction))) return false;
            if (this.TargetVersion != input.TargetVersion || (this.TargetVersion != null && !this.TargetVersion.Equals(input.TargetVersion))) return false;
            if (this.UpgradeShardNum != input.UpgradeShardNum || (this.UpgradeShardNum != null && !this.UpgradeShardNum.Equals(input.UpgradeShardNum))) return false;
            if (this.UpgradeAz != input.UpgradeAz || (this.UpgradeAz != null && !this.UpgradeAz.Equals(input.UpgradeAz))) return false;

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
                if (this.UpgradeType != null) hashCode = hashCode * 59 + this.UpgradeType.GetHashCode();
                if (this.UpgradeAction != null) hashCode = hashCode * 59 + this.UpgradeAction.GetHashCode();
                if (this.TargetVersion != null) hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                if (this.UpgradeShardNum != null) hashCode = hashCode * 59 + this.UpgradeShardNum.GetHashCode();
                if (this.UpgradeAz != null) hashCode = hashCode * 59 + this.UpgradeAz.GetHashCode();
                return hashCode;
            }
        }
    }
}
