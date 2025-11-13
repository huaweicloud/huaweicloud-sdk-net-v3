using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UploadImportExcelTemplateRequestBody : IFormDataBody
    {
        /// <summary>
        /// **参数解释**：  判断是否是实例级同步。  **约束限制**：  不涉及。  **取值范围**：  - true：实例级同步。 - false: 非实例级同步。  **默认取值**：  false。
        /// </summary>
        /// <value>**参数解释**：  判断是否是实例级同步。  **约束限制**：  不涉及。  **取值范围**：  - true：实例级同步。 - false: 非实例级同步。  **默认取值**：  false。</value>
        [JsonConverter(typeof(EnumClassConverter<IsInstanceLevelEnum>))]
        public class IsInstanceLevelEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly IsInstanceLevelEnum TRUE = new IsInstanceLevelEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly IsInstanceLevelEnum FALSE = new IsInstanceLevelEnum("false");

            private static readonly Dictionary<string, IsInstanceLevelEnum> StaticFields =
            new Dictionary<string, IsInstanceLevelEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public IsInstanceLevelEnum()
            {

            }

            public IsInstanceLevelEnum(string value)
            {
                _value = value;
            }

            public static IsInstanceLevelEnum FromValue(string value)
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

                if (this.Equals(obj as IsInstanceLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IsInstanceLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IsInstanceLevelEnum a, IsInstanceLevelEnum b)
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

            public static bool operator !=(IsInstanceLevelEnum a, IsInstanceLevelEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**：  是否支持标配符。  **约束限制**：  不涉及。  **取值范围**：  - true: 支持标配符。 - false: 不支持标配符。  **默认取值**：  不涉及。
        /// </summary>
        /// <value>**参数解释**：  是否支持标配符。  **约束限制**：  不涉及。  **取值范围**：  - true: 支持标配符。 - false: 不支持标配符。  **默认取值**：  不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<IsSupportRegexpEnum>))]
        public class IsSupportRegexpEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly IsSupportRegexpEnum TRUE = new IsSupportRegexpEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly IsSupportRegexpEnum FALSE = new IsSupportRegexpEnum("false");

            private static readonly Dictionary<string, IsSupportRegexpEnum> StaticFields =
            new Dictionary<string, IsSupportRegexpEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public IsSupportRegexpEnum()
            {

            }

            public IsSupportRegexpEnum(string value)
            {
                _value = value;
            }

            public static IsSupportRegexpEnum FromValue(string value)
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

                if (this.Equals(obj as IsSupportRegexpEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IsSupportRegexpEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IsSupportRegexpEnum a, IsSupportRegexpEnum b)
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

            public static bool operator !=(IsSupportRegexpEnum a, IsSupportRegexpEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：  具体选择哪一种模板进行下载。  **约束限制**：  不涉及。  **取值范围**：  import_async: Excel导入文件类型。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("template_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateType { get; set; }

        /// <summary>
        /// **参数解释**：  Excel文件上传。  **约束限制**：  Excel文件。  **取值范围**：  .xlsx文件。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("file", NullValueHandling = NullValueHandling.Ignore)]
        public FormDataFilePart File { get; set; }

        /// <summary>
        /// **参数解释**：  判断是否是实例级同步。  **约束限制**：  不涉及。  **取值范围**：  - true：实例级同步。 - false: 非实例级同步。  **默认取值**：  false。
        /// </summary>
        [JsonProperty("is_instance_level", NullValueHandling = NullValueHandling.Ignore)]
        public IsInstanceLevelEnum IsInstanceLevel { get; set; }
        /// <summary>
        /// **参数解释**：  用户选中的数据库名，用英文\&quot;,\&quot;隔开。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("selected_dbs", NullValueHandling = NullValueHandling.Ignore)]
        public string SelectedDbs { get; set; }

        /// <summary>
        /// **参数解释**：  是否支持标配符。  **约束限制**：  不涉及。  **取值范围**：  - true: 支持标配符。 - false: 不支持标配符。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("is_support_regexp", NullValueHandling = NullValueHandling.Ignore)]
        public IsSupportRegexpEnum IsSupportRegexp { get; set; }

        
        public UploadImportExcelTemplateRequestBody WithFile(Stream stream, string filename)
        {
            this.File = new FormDataFilePart(stream, filename);
            return this;
        }

        public UploadImportExcelTemplateRequestBody WithFile(Stream stream, string filename, string contentType)
        {
            this.File = new FormDataFilePart(stream, filename).WithContentType(contentType);
            return this;
        }
        

        public Dictionary<string, object> BuildFormData()
        {
            var formData = new Dictionary<string, object>();

            formData.Add("template_type", new FormDataPart<string>(TemplateType));
            formData.Add("file", File);
            if (IsInstanceLevel != null) {
                formData.Add("is_instance_level", new FormDataPart<string>(IsInstanceLevel.GetValue()));
            }
            formData.Add("selected_dbs", new FormDataPart<string>(SelectedDbs));
            if (IsSupportRegexp != null) {
                formData.Add("is_support_regexp", new FormDataPart<string>(IsSupportRegexp.GetValue()));
            }

            return formData;
        }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadImportExcelTemplateRequestBody {\n");
            sb.Append("  templateType: ").Append(TemplateType).Append("\n");
            sb.Append("  file: ").Append(File).Append("\n");
            sb.Append("  isInstanceLevel: ").Append(IsInstanceLevel).Append("\n");
            sb.Append("  selectedDbs: ").Append(SelectedDbs).Append("\n");
            sb.Append("  isSupportRegexp: ").Append(IsSupportRegexp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UploadImportExcelTemplateRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UploadImportExcelTemplateRequestBody input)
        {
            if (input == null) return false;
            if (this.TemplateType != input.TemplateType || (this.TemplateType != null && !this.TemplateType.Equals(input.TemplateType))) return false;
            if (this.File != input.File || (this.File != null && !this.File.Equals(input.File))) return false;
            if (this.IsInstanceLevel != input.IsInstanceLevel) return false;
            if (this.SelectedDbs != input.SelectedDbs || (this.SelectedDbs != null && !this.SelectedDbs.Equals(input.SelectedDbs))) return false;
            if (this.IsSupportRegexp != input.IsSupportRegexp) return false;

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
                if (this.TemplateType != null) hashCode = hashCode * 59 + this.TemplateType.GetHashCode();
                if (this.File != null) hashCode = hashCode * 59 + this.File.GetHashCode();
                hashCode = hashCode * 59 + this.IsInstanceLevel.GetHashCode();
                if (this.SelectedDbs != null) hashCode = hashCode * 59 + this.SelectedDbs.GetHashCode();
                hashCode = hashCode * 59 + this.IsSupportRegexp.GetHashCode();
                return hashCode;
            }
        }
    }
}
