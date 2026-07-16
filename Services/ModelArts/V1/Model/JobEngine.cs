using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 训练作业的引擎。使用算法管理的算法id或订阅算法subscription_id+item_version_id创建作业时，无需填写。
    /// </summary>
    public class JobEngine 
    {

        /// <summary>
        /// 训练作业选择的引擎规格ID。engine_id，engine_name+engine_version和image_url方式三选一。
        /// </summary>
        [JsonProperty("engine_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineId { get; set; }

        /// <summary>
        /// 训练作业选择的引擎名称。如果已填写engine_id，则此参数无需填写。
        /// </summary>
        [JsonProperty("engine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineName { get; set; }

        /// <summary>
        /// 训练作业选择的引擎版本名称。如果已填写engine_id，则此参数无需填写。
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// 训练作业选择的自定义镜像地址，地址从swr服务获取。
        /// </summary>
        [JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 是否需要安装训练平台指定的 moxing 版本。true为需要。只有填写了engine_name，engine_version，image_url参数时支持该设置。
        /// </summary>
        [JsonProperty("install_sys_packages", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InstallSysPackages { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobEngine {\n");
            sb.Append("  engineId: ").Append(EngineId).Append("\n");
            sb.Append("  engineName: ").Append(EngineName).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  imageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  installSysPackages: ").Append(InstallSysPackages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobEngine);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobEngine input)
        {
            if (input == null) return false;
            if (this.EngineId != input.EngineId || (this.EngineId != null && !this.EngineId.Equals(input.EngineId))) return false;
            if (this.EngineName != input.EngineName || (this.EngineName != null && !this.EngineName.Equals(input.EngineName))) return false;
            if (this.EngineVersion != input.EngineVersion || (this.EngineVersion != null && !this.EngineVersion.Equals(input.EngineVersion))) return false;
            if (this.ImageUrl != input.ImageUrl || (this.ImageUrl != null && !this.ImageUrl.Equals(input.ImageUrl))) return false;
            if (this.InstallSysPackages != input.InstallSysPackages || (this.InstallSysPackages != null && !this.InstallSysPackages.Equals(input.InstallSysPackages))) return false;

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
                if (this.EngineId != null) hashCode = hashCode * 59 + this.EngineId.GetHashCode();
                if (this.EngineName != null) hashCode = hashCode * 59 + this.EngineName.GetHashCode();
                if (this.EngineVersion != null) hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.ImageUrl != null) hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.InstallSysPackages != null) hashCode = hashCode * 59 + this.InstallSysPackages.GetHashCode();
                return hashCode;
            }
        }
    }
}
