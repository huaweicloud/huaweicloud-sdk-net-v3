using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Moderation.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TextDetectionReq 
    {

        /// <summary>
        /// 检测场景。  当前支持的场景有默认场景和用户自定义场景：  - 默认场景为：     * politics：涉政     * porn：涉黄     * ad：广告     * abuse：辱骂     * contraband：违禁品     * flood：灌水   - 用户自定义场景为：自定义黑名单词库。  &gt; - 自定义词库的创建和使用请参见[配置自定义词库](https://support.huaweicloud.com/api-moderation/moderation_03_0027.html)。 &gt; - flood场景不支持使用自定义白名单词库。
        /// </summary>
        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// 启用的白名单列表  当前白名单使用规则为：  - 不传参数\&quot;white_glossaries\&quot;：     * 表示默认使用2022-09-02 16:00:00之前创建的白名单词库  - 传参数\&quot;white_glossaries\&quot;：   * 参数为空时不使用任何白名单词库     * 参数不为空时使用传入的白名单词库  &gt; - 自定义词库的创建和使用请参见[[配置自定义词库](https://support.huaweicloud.com/api-moderation/moderation_03_0027.html)](tag:hc)。
        /// </summary>
        [JsonProperty("white_glossaries", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> WhiteGlossaries { get; set; }

        /// <summary>
        /// 待检测的文本列表，目前暂时每次只支持传一个item。
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<TextDetectionItemsReq> Items { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextDetectionReq {\n");
            sb.Append("  categories: ").Append(Categories).Append("\n");
            sb.Append("  whiteGlossaries: ").Append(WhiteGlossaries).Append("\n");
            sb.Append("  items: ").Append(Items).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TextDetectionReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TextDetectionReq input)
        {
            if (input == null) return false;
            if (this.Categories != input.Categories || (this.Categories != null && input.Categories != null && !this.Categories.SequenceEqual(input.Categories))) return false;
            if (this.WhiteGlossaries != input.WhiteGlossaries || (this.WhiteGlossaries != null && input.WhiteGlossaries != null && !this.WhiteGlossaries.SequenceEqual(input.WhiteGlossaries))) return false;
            if (this.Items != input.Items || (this.Items != null && input.Items != null && !this.Items.SequenceEqual(input.Items))) return false;

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
                if (this.Categories != null) hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.WhiteGlossaries != null) hashCode = hashCode * 59 + this.WhiteGlossaries.GetHashCode();
                if (this.Items != null) hashCode = hashCode * 59 + this.Items.GetHashCode();
                return hashCode;
            }
        }
    }
}
