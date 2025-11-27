using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 描述容器当前状态
    /// </summary>
    public class ContainerStatus 
    {

        /// <summary>
        /// 容器的唯一名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 当前容器状态
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public Object State { get; set; }

        /// <summary>
        /// 上次终止时的状态
        /// </summary>
        [JsonProperty("lastState", NullValueHandling = NullValueHandling.Ignore)]
        public string LastState { get; set; }

        /// <summary>
        /// 容器是否通过就绪检查
        /// </summary>
        [JsonProperty("ready", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ready { get; set; }

        /// <summary>
        /// 容器重启次数
        /// </summary>
        [JsonProperty("restartCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? RestartCount { get; set; }

        /// <summary>
        /// 容器运行的镜像名称
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>
        /// 容器运行的镜像ID
        /// </summary>
        [JsonProperty("imageID", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageID { get; set; }

        /// <summary>
        /// 容器是否已经成功启动并进入稳定运行阶段
        /// </summary>
        [JsonProperty("started", NullValueHandling = NullValueHandling.Ignore)]
        public string Started { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContainerStatus {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  lastState: ").Append(LastState).Append("\n");
            sb.Append("  ready: ").Append(Ready).Append("\n");
            sb.Append("  restartCount: ").Append(RestartCount).Append("\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  imageID: ").Append(ImageID).Append("\n");
            sb.Append("  started: ").Append(Started).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ContainerStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ContainerStatus input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.LastState != input.LastState || (this.LastState != null && !this.LastState.Equals(input.LastState))) return false;
            if (this.Ready != input.Ready || (this.Ready != null && !this.Ready.Equals(input.Ready))) return false;
            if (this.RestartCount != input.RestartCount || (this.RestartCount != null && !this.RestartCount.Equals(input.RestartCount))) return false;
            if (this.Image != input.Image || (this.Image != null && !this.Image.Equals(input.Image))) return false;
            if (this.ImageID != input.ImageID || (this.ImageID != null && !this.ImageID.Equals(input.ImageID))) return false;
            if (this.Started != input.Started || (this.Started != null && !this.Started.Equals(input.Started))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.LastState != null) hashCode = hashCode * 59 + this.LastState.GetHashCode();
                if (this.Ready != null) hashCode = hashCode * 59 + this.Ready.GetHashCode();
                if (this.RestartCount != null) hashCode = hashCode * 59 + this.RestartCount.GetHashCode();
                if (this.Image != null) hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.ImageID != null) hashCode = hashCode * 59 + this.ImageID.GetHashCode();
                if (this.Started != null) hashCode = hashCode * 59 + this.Started.GetHashCode();
                return hashCode;
            }
        }
    }
}
