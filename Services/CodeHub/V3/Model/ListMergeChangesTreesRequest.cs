using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListMergeChangesTreesRequest 
    {
        /// <summary>
        /// 是否为简易视图
        /// </summary>
        /// <value>是否为简易视图</value>
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
        /// 仓库主键id
        /// </summary>
        [SDKProperty("repository_id", IsPath = true)]
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// MR长id
        /// </summary>
        [SDKProperty("merge_request_iid", IsPath = true)]
        [JsonProperty("merge_request_iid", NullValueHandling = NullValueHandling.Ignore)]
        public string MergeRequestIid { get; set; }

        /// <summary>
        /// 是否为简易视图
        /// </summary>
        [SDKProperty("view", IsQuery = true)]
        [JsonProperty("view", NullValueHandling = NullValueHandling.Ignore)]
        public ViewEnum View { get; set; }
        /// <summary>
        /// commit的id
        /// </summary>
        [SDKProperty("commit_id", IsQuery = true)]
        [JsonProperty("commit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMergeChangesTreesRequest {\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  mergeRequestIid: ").Append(MergeRequestIid).Append("\n");
            sb.Append("  view: ").Append(View).Append("\n");
            sb.Append("  commitId: ").Append(CommitId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMergeChangesTreesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMergeChangesTreesRequest input)
        {
            if (input == null) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.MergeRequestIid != input.MergeRequestIid || (this.MergeRequestIid != null && !this.MergeRequestIid.Equals(input.MergeRequestIid))) return false;
            if (this.View != input.View) return false;
            if (this.CommitId != input.CommitId || (this.CommitId != null && !this.CommitId.Equals(input.CommitId))) return false;

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
                if (this.CommitId != null) hashCode = hashCode * 59 + this.CommitId.GetHashCode();
                return hashCode;
            }
        }
    }
}
