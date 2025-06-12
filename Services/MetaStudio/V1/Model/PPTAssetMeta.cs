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
    /// PPT资产元数据信息。
    /// </summary>
    public class PPTAssetMeta 
    {
        /// <summary>
        /// **参数解释**： PPT解析状态。 **约束限制**： 不涉及 **取值范围**： * INITIALIZE：初始 * WAITING：等待 * CONVERTING：解析中 * FAILED：失败 * SUCCEEDED：成功 * CANCELED：取消  **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： PPT解析状态。 **约束限制**： 不涉及 **取值范围**： * INITIALIZE：初始 * WAITING：等待 * CONVERTING：解析中 * FAILED：失败 * SUCCEEDED：成功 * CANCELED：取消  **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<PptAnalysisStatusEnum>))]
        public class PptAnalysisStatusEnum
        {
            /// <summary>
            /// Enum INITIALIZE for value: INITIALIZE
            /// </summary>
            public static readonly PptAnalysisStatusEnum INITIALIZE = new PptAnalysisStatusEnum("INITIALIZE");

            /// <summary>
            /// Enum WAITING for value: WAITING
            /// </summary>
            public static readonly PptAnalysisStatusEnum WAITING = new PptAnalysisStatusEnum("WAITING");

            /// <summary>
            /// Enum CONVERTING for value: CONVERTING
            /// </summary>
            public static readonly PptAnalysisStatusEnum CONVERTING = new PptAnalysisStatusEnum("CONVERTING");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly PptAnalysisStatusEnum FAILED = new PptAnalysisStatusEnum("FAILED");

            /// <summary>
            /// Enum SUCCEEDED for value: SUCCEEDED
            /// </summary>
            public static readonly PptAnalysisStatusEnum SUCCEEDED = new PptAnalysisStatusEnum("SUCCEEDED");

            /// <summary>
            /// Enum CANCELED for value: CANCELED
            /// </summary>
            public static readonly PptAnalysisStatusEnum CANCELED = new PptAnalysisStatusEnum("CANCELED");

            private static readonly Dictionary<string, PptAnalysisStatusEnum> StaticFields =
            new Dictionary<string, PptAnalysisStatusEnum>()
            {
                { "INITIALIZE", INITIALIZE },
                { "WAITING", WAITING },
                { "CONVERTING", CONVERTING },
                { "FAILED", FAILED },
                { "SUCCEEDED", SUCCEEDED },
                { "CANCELED", CANCELED },
            };

            private string _value;

            public PptAnalysisStatusEnum()
            {

            }

            public PptAnalysisStatusEnum(string value)
            {
                _value = value;
            }

            public static PptAnalysisStatusEnum FromValue(string value)
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

                if (this.Equals(obj as PptAnalysisStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PptAnalysisStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PptAnalysisStatusEnum a, PptAnalysisStatusEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(PptAnalysisStatusEnum a, PptAnalysisStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： PPT是否需要自动解析。 **约束限制**： 部分过于复杂的PPT或压缩比过高的PPT可能无法解析。 超过50页PPT仅转换50页 转换的图片无法保证完全还原，需要自行确认。 **取值范围**： * true: 自动解析 * false: 无需解析
        /// </summary>
        [JsonProperty("auto_analysis", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoAnalysis { get; set; }

        /// <summary>
        /// **参数解释**： PPT解析状态。 **约束限制**： 不涉及 **取值范围**： * INITIALIZE：初始 * WAITING：等待 * CONVERTING：解析中 * FAILED：失败 * SUCCEEDED：成功 * CANCELED：取消  **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("ppt_analysis_status", NullValueHandling = NullValueHandling.Ignore)]
        public PptAnalysisStatusEnum PptAnalysisStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error_info", NullValueHandling = NullValueHandling.Ignore)]
        public ErrorResponse ErrorInfo { get; set; }

        /// <summary>
        /// **参数解释**： PPT页面总数。 **约束限制**： 不涉及
        /// </summary>
        [JsonProperty("page_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageCount { get; set; }

        /// <summary>
        /// PPT页面图片。
        /// </summary>
        [JsonProperty("pages", NullValueHandling = NullValueHandling.Ignore)]
        public List<PPTPageInfo> Pages { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PPTAssetMeta {\n");
            sb.Append("  autoAnalysis: ").Append(AutoAnalysis).Append("\n");
            sb.Append("  pptAnalysisStatus: ").Append(PptAnalysisStatus).Append("\n");
            sb.Append("  errorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("  pageCount: ").Append(PageCount).Append("\n");
            sb.Append("  pages: ").Append(Pages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PPTAssetMeta);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PPTAssetMeta input)
        {
            if (input == null) return false;
            if (this.AutoAnalysis != input.AutoAnalysis || (this.AutoAnalysis != null && !this.AutoAnalysis.Equals(input.AutoAnalysis))) return false;
            if (this.PptAnalysisStatus != input.PptAnalysisStatus) return false;
            if (this.ErrorInfo != input.ErrorInfo || (this.ErrorInfo != null && !this.ErrorInfo.Equals(input.ErrorInfo))) return false;
            if (this.PageCount != input.PageCount || (this.PageCount != null && !this.PageCount.Equals(input.PageCount))) return false;
            if (this.Pages != input.Pages || (this.Pages != null && input.Pages != null && !this.Pages.SequenceEqual(input.Pages))) return false;

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
                if (this.AutoAnalysis != null) hashCode = hashCode * 59 + this.AutoAnalysis.GetHashCode();
                hashCode = hashCode * 59 + this.PptAnalysisStatus.GetHashCode();
                if (this.ErrorInfo != null) hashCode = hashCode * 59 + this.ErrorInfo.GetHashCode();
                if (this.PageCount != null) hashCode = hashCode * 59 + this.PageCount.GetHashCode();
                if (this.Pages != null) hashCode = hashCode * 59 + this.Pages.GetHashCode();
                return hashCode;
            }
        }
    }
}
