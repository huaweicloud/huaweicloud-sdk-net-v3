using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListMergeRequestCommitsRequest 
    {
        /// <summary>
        /// **参数解释：** 是否以简单模式展示commit，传值为simple时以简单模式展示，否则正常展示。 **约束限制 ** - simple, 以简单模式展示commit。
        /// </summary>
        /// <value>**参数解释：** 是否以简单模式展示commit，传值为simple时以简单模式展示，否则正常展示。 **约束限制 ** - simple, 以简单模式展示commit。</value>
        [JsonConverter(typeof(EnumClassConverter<ViewEnum>))]
        public class ViewEnum
        {
            /// <summary>
            /// Enum SIMPLE for value: simple
            /// </summary>
            public static readonly ViewEnum SIMPLE = new ViewEnum("simple");

            private static readonly Dictionary<string, ViewEnum> StaticFields =
            new Dictionary<string, ViewEnum>()
            {
                { "simple", SIMPLE },
            };

            private string _value;

            public ViewEnum()
            {

            }

            public ViewEnum(string value)
            {
                _value = value;
            }

            public static ViewEnum FromValue(string value)
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

                if (this.Equals(obj as ViewEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ViewEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ViewEnum a, ViewEnum b)
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

            public static bool operator !=(ViewEnum a, ViewEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 仓库的ID，通过[[查询用户所有仓库](https://support.huaweicloud.com/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws)[[查询用户所有仓库](https://support.huaweicloud.com/intl/en-us/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws_hk)[查询项目列表](tag:hcs,hcs_sm)接口查询项目列表获取。 **约束限制：** 不涉及。
        /// </summary>
        [SDKProperty("repository_id", IsPath = true)]
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// **参数解释：**  合并请求 iid。
        /// </summary>
        [SDKProperty("merge_request_iid", IsPath = true)]
        [JsonProperty("merge_request_iid", NullValueHandling = NullValueHandling.Ignore)]
        public int? MergeRequestIid { get; set; }

        /// <summary>
        /// **参数解释：** 是否以简单模式展示commit，传值为simple时以简单模式展示，否则正常展示。 **约束限制 ** - simple, 以简单模式展示commit。
        /// </summary>
        [SDKProperty("view", IsQuery = true)]
        [JsonProperty("view", NullValueHandling = NullValueHandling.Ignore)]
        public ViewEnum View { get; set; }
        /// <summary>
        /// **参数解释：** 偏移量，从0开始。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释：** 返回数量。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMergeRequestCommitsRequest {\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  mergeRequestIid: ").Append(MergeRequestIid).Append("\n");
            sb.Append("  view: ").Append(View).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMergeRequestCommitsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMergeRequestCommitsRequest input)
        {
            if (input == null) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.MergeRequestIid != input.MergeRequestIid || (this.MergeRequestIid != null && !this.MergeRequestIid.Equals(input.MergeRequestIid))) return false;
            if (this.View != input.View) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.RepositoryId != null) hashCode = hashCode * 59 + this.RepositoryId.GetHashCode();
                if (this.MergeRequestIid != null) hashCode = hashCode * 59 + this.MergeRequestIid.GetHashCode();
                hashCode = hashCode * 59 + this.View.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
