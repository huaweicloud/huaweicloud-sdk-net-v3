using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListAllAppRequestBody 
    {
        /// <summary>
        /// 排序字段的名称，当前仅支持name和startTime
        /// </summary>
        /// <value>排序字段的名称，当前仅支持name和startTime</value>
        [JsonConverter(typeof(EnumClassConverter<SortNameEnum>))]
        public class SortNameEnum
        {
            /// <summary>
            /// Enum NAME for value: name
            /// </summary>
            public static readonly SortNameEnum NAME = new SortNameEnum("name");

            /// <summary>
            /// Enum STARTTIME for value: startTime
            /// </summary>
            public static readonly SortNameEnum STARTTIME = new SortNameEnum("startTime");

            private static readonly Dictionary<string, SortNameEnum> StaticFields =
            new Dictionary<string, SortNameEnum>()
            {
                { "name", NAME },
                { "startTime", STARTTIME },
            };

            private string _value;

            public SortNameEnum()
            {

            }

            public SortNameEnum(string value)
            {
                _value = value;
            }

            public static SortNameEnum FromValue(string value)
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

                if (this.Equals(obj as SortNameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortNameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortNameEnum a, SortNameEnum b)
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

            public static bool operator !=(SortNameEnum a, SortNameEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 分页页码， 表示从此页开始查询， page大于等于1
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// 每页显示的条目数量，size小于等于100
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 排序字段的名称，当前仅支持name和startTime
        /// </summary>
        [JsonProperty("sort_name", NullValueHandling = NullValueHandling.Ignore)]
        public SortNameEnum SortName { get; set; }
        /// <summary>
        /// 排序顺序，正序（ASC）或者逆序（DESC)
        /// </summary>
        [JsonProperty("sort_by", NullValueHandling = NullValueHandling.Ignore)]
        public string SortBy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAllAppRequestBody {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  sortName: ").Append(SortName).Append("\n");
            sb.Append("  sortBy: ").Append(SortBy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAllAppRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAllAppRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.SortName == input.SortName ||
                    (this.SortName != null &&
                    this.SortName.Equals(input.SortName))
                ) && 
                (
                    this.SortBy == input.SortBy ||
                    (this.SortBy != null &&
                    this.SortBy.Equals(input.SortBy))
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
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.SortName != null)
                    hashCode = hashCode * 59 + this.SortName.GetHashCode();
                if (this.SortBy != null)
                    hashCode = hashCode * 59 + this.SortBy.GetHashCode();
                return hashCode;
            }
        }
    }
}
