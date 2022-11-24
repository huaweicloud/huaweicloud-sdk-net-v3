using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 用户容器镜像。
    /// </summary>
    public class CustomImage 
    {

        /// <summary>
        /// 是否启用
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 镜像地址
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>
        /// 启动容器镜像的命令
        /// </summary>
        [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
        public string Command { get; set; }

        /// <summary>
        /// 启动容器镜像的命令行参数
        /// </summary>
        [JsonProperty("args", NullValueHandling = NullValueHandling.Ignore)]
        public string Args { get; set; }

        /// <summary>
        /// 镜像容器工作目录
        /// </summary>
        [JsonProperty("working_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkingDir { get; set; }

        /// <summary>
        /// 镜像容器的用户id
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// 镜像容器的用户组id
        /// </summary>
        [JsonProperty("gid", NullValueHandling = NullValueHandling.Ignore)]
        public string Gid { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomImage {\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  command: ").Append(Command).Append("\n");
            sb.Append("  args: ").Append(Args).Append("\n");
            sb.Append("  workingDir: ").Append(WorkingDir).Append("\n");
            sb.Append("  uid: ").Append(Uid).Append("\n");
            sb.Append("  gid: ").Append(Gid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomImage);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomImage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Command == input.Command ||
                    (this.Command != null &&
                    this.Command.Equals(input.Command))
                ) && 
                (
                    this.Args == input.Args ||
                    (this.Args != null &&
                    this.Args.Equals(input.Args))
                ) && 
                (
                    this.WorkingDir == input.WorkingDir ||
                    (this.WorkingDir != null &&
                    this.WorkingDir.Equals(input.WorkingDir))
                ) && 
                (
                    this.Uid == input.Uid ||
                    (this.Uid != null &&
                    this.Uid.Equals(input.Uid))
                ) && 
                (
                    this.Gid == input.Gid ||
                    (this.Gid != null &&
                    this.Gid.Equals(input.Gid))
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
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Command != null)
                    hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.Args != null)
                    hashCode = hashCode * 59 + this.Args.GetHashCode();
                if (this.WorkingDir != null)
                    hashCode = hashCode * 59 + this.WorkingDir.GetHashCode();
                if (this.Uid != null)
                    hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.Gid != null)
                    hashCode = hashCode * 59 + this.Gid.GetHashCode();
                return hashCode;
            }
        }
    }
}
