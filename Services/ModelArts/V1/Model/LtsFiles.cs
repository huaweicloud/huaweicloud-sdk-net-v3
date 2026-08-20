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
    /// **参数解释：**  容器日志文件配置。 **约束限制：**  数量上限为10个。
    /// </summary>
    public class LtsFiles 
    {

        /// <summary>
        /// **参数解释：** 日志文件路径。 **约束限制：** 1.路径必须以 / 开头，且第一级目录不能使用通配符，只能包含大写字母，小写字母，数字或特殊符号-_/_*?，长度不能超过 512 个字符。 2.最多允许三级目录使用通配符进行匹配。 **取值范围：** 不涉及 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("log_path", NullValueHandling = NullValueHandling.Ignore)]
        public string LogPath { get; set; }

        /// <summary>
        /// **参数解释：** 日志文件名称。 **约束限制：** 只能包含大写字母，小写字母，数字或特殊字符-_*?，不支持.gz .tar .zip后缀类型，长度不能超过 255 个字符。 **取值范围：** 不涉及 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("file_pattern", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePattern { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LtsFiles {\n");
            sb.Append("  logPath: ").Append(LogPath).Append("\n");
            sb.Append("  filePattern: ").Append(FilePattern).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LtsFiles);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LtsFiles input)
        {
            if (input == null) return false;
            if (this.LogPath != input.LogPath || (this.LogPath != null && !this.LogPath.Equals(input.LogPath))) return false;
            if (this.FilePattern != input.FilePattern || (this.FilePattern != null && !this.FilePattern.Equals(input.FilePattern))) return false;

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
                if (this.LogPath != null) hashCode = hashCode * 59 + this.LogPath.GetHashCode();
                if (this.FilePattern != null) hashCode = hashCode * 59 + this.FilePattern.GetHashCode();
                return hashCode;
            }
        }
    }
}
