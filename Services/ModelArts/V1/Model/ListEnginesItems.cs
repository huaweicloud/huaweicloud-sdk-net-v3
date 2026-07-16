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
    /// 
    /// </summary>
    public class ListEnginesItems 
    {

        /// <summary>
        /// 引擎规格的ID。如“caffe-1.0.0-python2.7”。
        /// </summary>
        [JsonProperty("engine_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineId { get; set; }

        /// <summary>
        /// 引擎规格的名称。如“Caffe”。
        /// </summary>
        [JsonProperty("engine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineName { get; set; }

        /// <summary>
        /// 引擎规格的版本。对一个引擎名称，有多个版本的引擎，如使用python2.7的\&quot;Caffe-1.0.0-python2.7\&quot;等。
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// 是否为v1兼容模式。
        /// </summary>
        [JsonProperty("v1_compatible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? V1Compatible { get; set; }

        /// <summary>
        /// 引擎默认启动用户uid。
        /// </summary>
        [JsonProperty("run_user", NullValueHandling = NullValueHandling.Ignore)]
        public string RunUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image_info", NullValueHandling = NullValueHandling.Ignore)]
        public ListEnginesImageInfo ImageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEnginesItems {\n");
            sb.Append("  engineId: ").Append(EngineId).Append("\n");
            sb.Append("  engineName: ").Append(EngineName).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  v1Compatible: ").Append(V1Compatible).Append("\n");
            sb.Append("  runUser: ").Append(RunUser).Append("\n");
            sb.Append("  imageInfo: ").Append(ImageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEnginesItems);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEnginesItems input)
        {
            if (input == null) return false;
            if (this.EngineId != input.EngineId || (this.EngineId != null && !this.EngineId.Equals(input.EngineId))) return false;
            if (this.EngineName != input.EngineName || (this.EngineName != null && !this.EngineName.Equals(input.EngineName))) return false;
            if (this.EngineVersion != input.EngineVersion || (this.EngineVersion != null && !this.EngineVersion.Equals(input.EngineVersion))) return false;
            if (this.V1Compatible != input.V1Compatible || (this.V1Compatible != null && !this.V1Compatible.Equals(input.V1Compatible))) return false;
            if (this.RunUser != input.RunUser || (this.RunUser != null && !this.RunUser.Equals(input.RunUser))) return false;
            if (this.ImageInfo != input.ImageInfo || (this.ImageInfo != null && !this.ImageInfo.Equals(input.ImageInfo))) return false;

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
                if (this.V1Compatible != null) hashCode = hashCode * 59 + this.V1Compatible.GetHashCode();
                if (this.RunUser != null) hashCode = hashCode * 59 + this.RunUser.GetHashCode();
                if (this.ImageInfo != null) hashCode = hashCode * 59 + this.ImageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
