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
    public class HumanModelMetaProperties 
    {

        /// <summary>
        /// **参数解释**： 用于生成WHOLE_MODEL的模型file_id **约束限制**： 如果当前记录的信息与MAIN文件的file_id一致，那就认为已经生成过，无需再进行全模型导出 **取值范围**： 字符长度0-64位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("whole_model_base_file_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WholeModelBaseFileId { get; set; }

        /// <summary>
        /// **参数解释**： 当前用于渲染加载的模型file_id **约束限制**： 若为空或未匹配到，则使用MAIN文件 **取值范围**： 字符长度0-64位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("load_model_file_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LoadModelFileId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HumanModelMetaProperties {\n");
            sb.Append("  wholeModelBaseFileId: ").Append(WholeModelBaseFileId).Append("\n");
            sb.Append("  loadModelFileId: ").Append(LoadModelFileId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HumanModelMetaProperties);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HumanModelMetaProperties input)
        {
            if (input == null) return false;
            if (this.WholeModelBaseFileId != input.WholeModelBaseFileId || (this.WholeModelBaseFileId != null && !this.WholeModelBaseFileId.Equals(input.WholeModelBaseFileId))) return false;
            if (this.LoadModelFileId != input.LoadModelFileId || (this.LoadModelFileId != null && !this.LoadModelFileId.Equals(input.LoadModelFileId))) return false;

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
                if (this.WholeModelBaseFileId != null) hashCode = hashCode * 59 + this.WholeModelBaseFileId.GetHashCode();
                if (this.LoadModelFileId != null) hashCode = hashCode * 59 + this.LoadModelFileId.GetHashCode();
                return hashCode;
            }
        }
    }
}
