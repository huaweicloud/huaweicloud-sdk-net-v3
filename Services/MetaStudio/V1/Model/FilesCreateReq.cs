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
    /// 创建文件请求。
    /// </summary>
    public class FilesCreateReq 
    {

        /// <summary>
        /// **参数解释**： 文件名。 **约束限制**： 不区分大小写。 **取值范围**： 字符长度1-256位。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// **参数解释**： 文件内容MD5值。按照RFC 1864标准计算出消息体的MD5摘要字符串，即消息体128-bit MD5值经过base64编码后得到的字符串。 md5值获取详情请参考[使用Java代码生成文件内容的MD5值](metastudio_02_0052.xml)。 **约束限制**： 不涉及 **取值范围**： 字符长度24位。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("file_md5", NullValueHandling = NullValueHandling.Ignore)]
        public string FileMd5 { get; set; }

        /// <summary>
        /// **参数解释**： 文件总的大小。 **约束限制**： 最大支持5GB  **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("file_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? FileSize { get; set; }

        /// <summary>
        /// **参数解释**： 文件类型 **约束限制**： 不涉及 **取值范围**： 字符长度1-64位。 **默认取值**： 默认提取文件后缀。
        /// </summary>
        [JsonProperty("file_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FileType { get; set; }

        /// <summary>
        /// **参数解释**： 本平台资产ID。 **约束限制**： 不涉及 **取值范围**： 字符长度1-64位。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// **参数解释**： 文件在资产中的分类。每种资产类型包含的文件分类不同。 * MAIN：主文件 * COVER：封面文件 * PAGE：PPT内容页图片文件 * SAMPLE：样例音频或样例动作文件 * OTHER：其他文件 * WHOLE_MODEL：全模型文件（3D数字人） * USER_MODIFIED_MODEL：用户上传模型（3D数字人） * TEMPORARY：临时文件夹（用于文件替换时上传新文件） * PACKAGE：打包后的资产文件 &gt; * 资产类型为SCENE、ANIMATION、VIDEO、IMAGE、MATERIAL时，包含MAIN、COVER和OTHER &gt; * 资产类型为PPT时，包含MAIN、COVER、PAGE和OTHER &gt; * 资产类型为HUMAN_MODEL时，包含MAIN、COVER、WHOLE_MODEL、USER_MODIFIED_MODEL和OTHER &gt; * 资产类型为VOICE_MODEL时，包含MAIN、SAMPLE(样例音频文件)和OTHER &gt; * 资产类型为HUMAN_MODEL_2D时，包含MAIN、COVER、SAMPLE(动作样例)和OTHER &gt; * 资产类型为BUSINESS_CARD_TEMPLET时，包含MAIN和COVER(名片效果图) &gt; * 资产类型为IMAGE时，包含MAIN &gt; * 资产类型为VIDEO时，包含MAIN、COVER  **约束限制**： 一个资产中MAIN文件只有一个，且必须有一个 **取值范围**： 字符长度1-128位。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("asset_file_category", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetFileCategory { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilesCreateReq {\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  fileMd5: ").Append(FileMd5).Append("\n");
            sb.Append("  fileSize: ").Append(FileSize).Append("\n");
            sb.Append("  fileType: ").Append(FileType).Append("\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  assetFileCategory: ").Append(AssetFileCategory).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FilesCreateReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FilesCreateReq input)
        {
            if (input == null) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.FileMd5 != input.FileMd5 || (this.FileMd5 != null && !this.FileMd5.Equals(input.FileMd5))) return false;
            if (this.FileSize != input.FileSize || (this.FileSize != null && !this.FileSize.Equals(input.FileSize))) return false;
            if (this.FileType != input.FileType || (this.FileType != null && !this.FileType.Equals(input.FileType))) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.AssetFileCategory != input.AssetFileCategory || (this.AssetFileCategory != null && !this.AssetFileCategory.Equals(input.AssetFileCategory))) return false;

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
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.FileMd5 != null) hashCode = hashCode * 59 + this.FileMd5.GetHashCode();
                if (this.FileSize != null) hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                if (this.FileType != null) hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.AssetFileCategory != null) hashCode = hashCode * 59 + this.AssetFileCategory.GetHashCode();
                return hashCode;
            }
        }
    }
}
