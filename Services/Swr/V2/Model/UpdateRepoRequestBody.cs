using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateRepoRequestBody 
    {
        /// <summary>
        /// 仓库类型，可设置为app_server, linux, framework_app, database, lang, other, windows, arm。
        /// </summary>
        /// <value>仓库类型，可设置为app_server, linux, framework_app, database, lang, other, windows, arm。</value>
        [JsonConverter(typeof(EnumClassConverter<CategoryEnum>))]
        public class CategoryEnum
        {
            /// <summary>
            /// Enum APP_SERVER for value: app_server
            /// </summary>
            public static readonly CategoryEnum APP_SERVER = new CategoryEnum("app_server");

            /// <summary>
            /// Enum LINUX for value: linux
            /// </summary>
            public static readonly CategoryEnum LINUX = new CategoryEnum("linux");

            /// <summary>
            /// Enum FRAMEWORK_APP for value: framework_app
            /// </summary>
            public static readonly CategoryEnum FRAMEWORK_APP = new CategoryEnum("framework_app");

            /// <summary>
            /// Enum DATABASE for value: database
            /// </summary>
            public static readonly CategoryEnum DATABASE = new CategoryEnum("database");

            /// <summary>
            /// Enum LANG for value: lang
            /// </summary>
            public static readonly CategoryEnum LANG = new CategoryEnum("lang");

            /// <summary>
            /// Enum WINDOWS for value: windows
            /// </summary>
            public static readonly CategoryEnum WINDOWS = new CategoryEnum("windows");

            /// <summary>
            /// Enum ARMS for value: arms
            /// </summary>
            public static readonly CategoryEnum ARMS = new CategoryEnum("arms");

            /// <summary>
            /// Enum OTHER for value: other
            /// </summary>
            public static readonly CategoryEnum OTHER = new CategoryEnum("other");

            private static readonly Dictionary<string, CategoryEnum> StaticFields =
            new Dictionary<string, CategoryEnum>()
            {
                { "app_server", APP_SERVER },
                { "linux", LINUX },
                { "framework_app", FRAMEWORK_APP },
                { "database", DATABASE },
                { "lang", LANG },
                { "windows", WINDOWS },
                { "arms", ARMS },
                { "other", OTHER },
            };

            private string _value;

            public CategoryEnum()
            {

            }

            public CategoryEnum(string value)
            {
                _value = value;
            }

            public static CategoryEnum FromValue(string value)
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

                if (this.Equals(obj as CategoryEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CategoryEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CategoryEnum a, CategoryEnum b)
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

            public static bool operator !=(CategoryEnum a, CategoryEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 是否为公共仓库，可选值为true或false。
        /// </summary>
        [JsonProperty("is_public", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// 仓库类型，可设置为app_server, linux, framework_app, database, lang, other, windows, arm。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryEnum Category { get; set; }
        /// <summary>
        /// 镜像仓库的描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRepoRequestBody {\n");
            sb.Append("  isPublic: ").Append(IsPublic).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateRepoRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateRepoRequestBody input)
        {
            if (input == null) return false;
            if (this.IsPublic != input.IsPublic || (this.IsPublic != null && !this.IsPublic.Equals(input.IsPublic))) return false;
            if (this.Category != input.Category) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.IsPublic != null) hashCode = hashCode * 59 + this.IsPublic.GetHashCode();
                hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
