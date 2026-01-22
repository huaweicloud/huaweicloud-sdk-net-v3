using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowShareFeatureGatesResponse : SdkResponse
    {

        /// <summary>
        /// 是否支持体验馆
        /// </summary>
        [JsonProperty("enable_experience", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableExperience { get; set; }

        /// <summary>
        /// 是否支持对接hss服务
        /// </summary>
        [JsonProperty("enable_hss_service", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableHssService { get; set; }

        /// <summary>
        /// 是否支持镜像扫描
        /// </summary>
        [JsonProperty("enable_image_scan", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableImageScan { get; set; }

        /// <summary>
        /// 是否支持国密场景
        /// </summary>
        [JsonProperty("enable_sm3", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSm3 { get; set; }

        /// <summary>
        /// 是否支持镜像同步
        /// </summary>
        [JsonProperty("enable_image_sync", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableImageSync { get; set; }

        /// <summary>
        /// 是否支持对接cci服务
        /// </summary>
        [JsonProperty("enable_cci_service", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableCciService { get; set; }

        /// <summary>
        /// 是否支持镜像标签
        /// </summary>
        [JsonProperty("enable_image_label", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableImageLabel { get; set; }

        /// <summary>
        /// 是否支持流水线服务
        /// </summary>
        [JsonProperty("enable_pipeline", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnablePipeline { get; set; }

        /// <summary>
        /// 是否支持增强型临时登录指令。设置为true时，前端获取登录指令时可以选择获取增强型登录指令。
        /// </summary>
        [JsonProperty("enable_authorization_token", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAuthorizationToken { get; set; }

        /// <summary>
        /// 是否支持镜像资源。设置为true时，前端界面显示“镜像资源”页签，可查看镜像中心。
        /// </summary>
        [JsonProperty("enable_resource", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableResource { get; set; }

        /// <summary>
        /// 是否支持list v3接口
        /// </summary>
        [JsonProperty("enable_list_v3", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableListV3 { get; set; }

        /// <summary>
        /// 是否启用镜像配额
        /// </summary>
        [JsonProperty("enable_image_quota", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableImageQuota { get; set; }

        /// <summary>
        /// 是否支持自定义临时登录指令有效期
        /// </summary>
        [JsonProperty("enable_customize_validity_period", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableCustomizeValidityPeriod { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowShareFeatureGatesResponse {\n");
            sb.Append("  enableExperience: ").Append(EnableExperience).Append("\n");
            sb.Append("  enableHssService: ").Append(EnableHssService).Append("\n");
            sb.Append("  enableImageScan: ").Append(EnableImageScan).Append("\n");
            sb.Append("  enableSm3: ").Append(EnableSm3).Append("\n");
            sb.Append("  enableImageSync: ").Append(EnableImageSync).Append("\n");
            sb.Append("  enableCciService: ").Append(EnableCciService).Append("\n");
            sb.Append("  enableImageLabel: ").Append(EnableImageLabel).Append("\n");
            sb.Append("  enablePipeline: ").Append(EnablePipeline).Append("\n");
            sb.Append("  enableAuthorizationToken: ").Append(EnableAuthorizationToken).Append("\n");
            sb.Append("  enableResource: ").Append(EnableResource).Append("\n");
            sb.Append("  enableListV3: ").Append(EnableListV3).Append("\n");
            sb.Append("  enableImageQuota: ").Append(EnableImageQuota).Append("\n");
            sb.Append("  enableCustomizeValidityPeriod: ").Append(EnableCustomizeValidityPeriod).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowShareFeatureGatesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowShareFeatureGatesResponse input)
        {
            if (input == null) return false;
            if (this.EnableExperience != input.EnableExperience || (this.EnableExperience != null && !this.EnableExperience.Equals(input.EnableExperience))) return false;
            if (this.EnableHssService != input.EnableHssService || (this.EnableHssService != null && !this.EnableHssService.Equals(input.EnableHssService))) return false;
            if (this.EnableImageScan != input.EnableImageScan || (this.EnableImageScan != null && !this.EnableImageScan.Equals(input.EnableImageScan))) return false;
            if (this.EnableSm3 != input.EnableSm3 || (this.EnableSm3 != null && !this.EnableSm3.Equals(input.EnableSm3))) return false;
            if (this.EnableImageSync != input.EnableImageSync || (this.EnableImageSync != null && !this.EnableImageSync.Equals(input.EnableImageSync))) return false;
            if (this.EnableCciService != input.EnableCciService || (this.EnableCciService != null && !this.EnableCciService.Equals(input.EnableCciService))) return false;
            if (this.EnableImageLabel != input.EnableImageLabel || (this.EnableImageLabel != null && !this.EnableImageLabel.Equals(input.EnableImageLabel))) return false;
            if (this.EnablePipeline != input.EnablePipeline || (this.EnablePipeline != null && !this.EnablePipeline.Equals(input.EnablePipeline))) return false;
            if (this.EnableAuthorizationToken != input.EnableAuthorizationToken || (this.EnableAuthorizationToken != null && !this.EnableAuthorizationToken.Equals(input.EnableAuthorizationToken))) return false;
            if (this.EnableResource != input.EnableResource || (this.EnableResource != null && !this.EnableResource.Equals(input.EnableResource))) return false;
            if (this.EnableListV3 != input.EnableListV3 || (this.EnableListV3 != null && !this.EnableListV3.Equals(input.EnableListV3))) return false;
            if (this.EnableImageQuota != input.EnableImageQuota || (this.EnableImageQuota != null && !this.EnableImageQuota.Equals(input.EnableImageQuota))) return false;
            if (this.EnableCustomizeValidityPeriod != input.EnableCustomizeValidityPeriod || (this.EnableCustomizeValidityPeriod != null && !this.EnableCustomizeValidityPeriod.Equals(input.EnableCustomizeValidityPeriod))) return false;

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
                if (this.EnableExperience != null) hashCode = hashCode * 59 + this.EnableExperience.GetHashCode();
                if (this.EnableHssService != null) hashCode = hashCode * 59 + this.EnableHssService.GetHashCode();
                if (this.EnableImageScan != null) hashCode = hashCode * 59 + this.EnableImageScan.GetHashCode();
                if (this.EnableSm3 != null) hashCode = hashCode * 59 + this.EnableSm3.GetHashCode();
                if (this.EnableImageSync != null) hashCode = hashCode * 59 + this.EnableImageSync.GetHashCode();
                if (this.EnableCciService != null) hashCode = hashCode * 59 + this.EnableCciService.GetHashCode();
                if (this.EnableImageLabel != null) hashCode = hashCode * 59 + this.EnableImageLabel.GetHashCode();
                if (this.EnablePipeline != null) hashCode = hashCode * 59 + this.EnablePipeline.GetHashCode();
                if (this.EnableAuthorizationToken != null) hashCode = hashCode * 59 + this.EnableAuthorizationToken.GetHashCode();
                if (this.EnableResource != null) hashCode = hashCode * 59 + this.EnableResource.GetHashCode();
                if (this.EnableListV3 != null) hashCode = hashCode * 59 + this.EnableListV3.GetHashCode();
                if (this.EnableImageQuota != null) hashCode = hashCode * 59 + this.EnableImageQuota.GetHashCode();
                if (this.EnableCustomizeValidityPeriod != null) hashCode = hashCode * 59 + this.EnableCustomizeValidityPeriod.GetHashCode();
                return hashCode;
            }
        }
    }
}
