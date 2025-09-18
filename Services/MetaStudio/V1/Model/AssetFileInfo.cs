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
    /// 文件信息。
    /// </summary>
    public class AssetFileInfo 
    {
        /// <summary>
        /// 文件状态枚举: * CREATING：文件上传中 * CREATED：文件已上传（自动审核通过） * FAILED：文件上传失败 * CANCELLED：文件上传已取消 * DELETING：文件删除中 * DELETED：文件已删除 * UPLOADED：文件已上传（尚未审核） * REVIEW：人工审核（文件已上传） * BLOCK：冻结
        /// </summary>
        /// <value>文件状态枚举: * CREATING：文件上传中 * CREATED：文件已上传（自动审核通过） * FAILED：文件上传失败 * CANCELLED：文件上传已取消 * DELETING：文件删除中 * DELETED：文件已删除 * UPLOADED：文件已上传（尚未审核） * REVIEW：人工审核（文件已上传） * BLOCK：冻结</value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum CREATING for value: CREATING
            /// </summary>
            public static readonly StateEnum CREATING = new StateEnum("CREATING");

            /// <summary>
            /// Enum CREATED for value: CREATED
            /// </summary>
            public static readonly StateEnum CREATED = new StateEnum("CREATED");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly StateEnum FAILED = new StateEnum("FAILED");

            /// <summary>
            /// Enum CANCELLED for value: CANCELLED
            /// </summary>
            public static readonly StateEnum CANCELLED = new StateEnum("CANCELLED");

            /// <summary>
            /// Enum DELETING for value: DELETING
            /// </summary>
            public static readonly StateEnum DELETING = new StateEnum("DELETING");

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            public static readonly StateEnum DELETED = new StateEnum("DELETED");

            /// <summary>
            /// Enum UPLOADED for value: UPLOADED
            /// </summary>
            public static readonly StateEnum UPLOADED = new StateEnum("UPLOADED");

            /// <summary>
            /// Enum REVIEW for value: REVIEW
            /// </summary>
            public static readonly StateEnum REVIEW = new StateEnum("REVIEW");

            /// <summary>
            /// Enum BLOCK for value: BLOCK
            /// </summary>
            public static readonly StateEnum BLOCK = new StateEnum("BLOCK");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "CREATING", CREATING },
                { "CREATED", CREATED },
                { "FAILED", FAILED },
                { "CANCELLED", CANCELLED },
                { "DELETING", DELETING },
                { "DELETED", DELETED },
                { "UPLOADED", UPLOADED },
                { "REVIEW", REVIEW },
                { "BLOCK", BLOCK },
            };

            private string _value;

            public StateEnum()
            {

            }

            public StateEnum(string value)
            {
                _value = value;
            }

            public static StateEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as StateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StateEnum a, StateEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(StateEnum a, StateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 文件ID。
        /// </summary>
        [JsonProperty("file_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FileId { get; set; }

        /// <summary>
        /// 文件名创建文件时候不区分大小写，最大长度256，最小长度1。
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 文件内容MD5值，固定24位。
        /// </summary>
        [JsonProperty("file_md5", NullValueHandling = NullValueHandling.Ignore)]
        public string FileMd5 { get; set; }

        /// <summary>
        /// 文件总的大小，最小1，最大5368709120。
        /// </summary>
        [JsonProperty("file_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? FileSize { get; set; }

        /// <summary>
        /// 文件类型（默认提取文件后缀）。
        /// </summary>
        [JsonProperty("file_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FileType { get; set; }

        /// <summary>
        /// 文件在资产中的分类。每种资产类型包含的文件分类不同。 * MAIN：主文件 * COVER：封面文件 * PAGE：内容页图片 * SAMPLE：样例音频 * OTHER：其他文件 * TEMPORARY：临时文件夹（用于文件替换时上传新文件） * PACKAGE：打包后的资产文件 &gt; * 资产类型为PPT时，包含MAIN、COVER、PAGE和OTHER &gt; * 资产类型为VOICE_MODEL时，包含MAIN、SAMPLE(样例音频文件)和OTHER &gt; * 资产类型为HUMAN_MODEL_2D时，包含MAIN、COVER、SAMPLE(动作样例)和OTHER(遮罩文件) &gt; * 资产类型为BUSINESS_CARD_TEMPLET时，包含MAIN和COVER(名片效果图)
        /// </summary>
        [JsonProperty("asset_file_category", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetFileCategory { get; set; }

        /// <summary>
        /// 文件下载URL，有效期为24小时。
        /// </summary>
        [JsonProperty("download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 文件状态枚举: * CREATING：文件上传中 * CREATED：文件已上传（自动审核通过） * FAILED：文件上传失败 * CANCELLED：文件上传已取消 * DELETING：文件删除中 * DELETED：文件已删除 * UPLOADED：文件已上传（尚未审核） * REVIEW：人工审核（文件已上传） * BLOCK：冻结
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }
        /// <summary>
        /// 冻结原因编号。
        /// </summary>
        [JsonProperty("block_reason_code", NullValueHandling = NullValueHandling.Ignore)]
        public string BlockReasonCode { get; set; }

        /// <summary>
        /// 审核失败原因
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("file_extra_meta", NullValueHandling = NullValueHandling.Ignore)]
        public FileExtraMeta FileExtraMeta { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetFileInfo {\n");
            sb.Append("  fileId: ").Append(FileId).Append("\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  fileMd5: ").Append(FileMd5).Append("\n");
            sb.Append("  fileSize: ").Append(FileSize).Append("\n");
            sb.Append("  fileType: ").Append(FileType).Append("\n");
            sb.Append("  assetFileCategory: ").Append(AssetFileCategory).Append("\n");
            sb.Append("  downloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  blockReasonCode: ").Append(BlockReasonCode).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("  fileExtraMeta: ").Append(FileExtraMeta).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssetFileInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssetFileInfo input)
        {
            if (input == null) return false;
            if (this.FileId != input.FileId || (this.FileId != null && !this.FileId.Equals(input.FileId))) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.FileMd5 != input.FileMd5 || (this.FileMd5 != null && !this.FileMd5.Equals(input.FileMd5))) return false;
            if (this.FileSize != input.FileSize || (this.FileSize != null && !this.FileSize.Equals(input.FileSize))) return false;
            if (this.FileType != input.FileType || (this.FileType != null && !this.FileType.Equals(input.FileType))) return false;
            if (this.AssetFileCategory != input.AssetFileCategory || (this.AssetFileCategory != null && !this.AssetFileCategory.Equals(input.AssetFileCategory))) return false;
            if (this.DownloadUrl != input.DownloadUrl || (this.DownloadUrl != null && !this.DownloadUrl.Equals(input.DownloadUrl))) return false;
            if (this.State != input.State) return false;
            if (this.BlockReasonCode != input.BlockReasonCode || (this.BlockReasonCode != null && !this.BlockReasonCode.Equals(input.BlockReasonCode))) return false;
            if (this.Reason != input.Reason || (this.Reason != null && !this.Reason.Equals(input.Reason))) return false;
            if (this.FileExtraMeta != input.FileExtraMeta || (this.FileExtraMeta != null && !this.FileExtraMeta.Equals(input.FileExtraMeta))) return false;

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
                if (this.FileId != null) hashCode = hashCode * 59 + this.FileId.GetHashCode();
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.FileMd5 != null) hashCode = hashCode * 59 + this.FileMd5.GetHashCode();
                if (this.FileSize != null) hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                if (this.FileType != null) hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.AssetFileCategory != null) hashCode = hashCode * 59 + this.AssetFileCategory.GetHashCode();
                if (this.DownloadUrl != null) hashCode = hashCode * 59 + this.DownloadUrl.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.BlockReasonCode != null) hashCode = hashCode * 59 + this.BlockReasonCode.GetHashCode();
                if (this.Reason != null) hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.FileExtraMeta != null) hashCode = hashCode * 59 + this.FileExtraMeta.GetHashCode();
                return hashCode;
            }
        }
    }
}
