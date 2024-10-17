using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowJobDetailRequest 
    {
        /// <summary>
        /// 请求语言类型。
        /// </summary>
        /// <value>请求语言类型。</value>
        [JsonConverter(typeof(EnumClassConverter<XLanguageEnum>))]
        public class XLanguageEnum
        {
            /// <summary>
            /// Enum EN_US for value: en-us
            /// </summary>
            public static readonly XLanguageEnum EN_US = new XLanguageEnum("en-us");

            /// <summary>
            /// Enum ZH_CN for value: zh-cn
            /// </summary>
            public static readonly XLanguageEnum ZH_CN = new XLanguageEnum("zh-cn");

            private static readonly Dictionary<string, XLanguageEnum> StaticFields =
            new Dictionary<string, XLanguageEnum>()
            {
                { "en-us", EN_US },
                { "zh-cn", ZH_CN },
            };

            private string _value;

            public XLanguageEnum()
            {

            }

            public XLanguageEnum(string value)
            {
                _value = value;
            }

            public static XLanguageEnum FromValue(string value)
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

                if (this.Equals(obj as XLanguageEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(XLanguageEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(XLanguageEnum a, XLanguageEnum b)
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

            public static bool operator !=(XLanguageEnum a, XLanguageEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 任务详情类型。取值： - overview：任务概览信息。 - detail：任务基本信息。 - network：测试连接结果信息，需配合query_id参数一起查询。 - precheck：预检查结果信息，需配合query_id参数一起查询。 - progress：任务进度信息。 - log：任务日志信息，支持分页查询参数offset与limit。 - compare：查询对比任务。 - file：对象导入信息。 - is_writable：目标库解除只读结果。 - cloud_connection：录制回放他云连通性测试，需配合query_id参数一起查询。
        /// </summary>
        /// <value>任务详情类型。取值： - overview：任务概览信息。 - detail：任务基本信息。 - network：测试连接结果信息，需配合query_id参数一起查询。 - precheck：预检查结果信息，需配合query_id参数一起查询。 - progress：任务进度信息。 - log：任务日志信息，支持分页查询参数offset与limit。 - compare：查询对比任务。 - file：对象导入信息。 - is_writable：目标库解除只读结果。 - cloud_connection：录制回放他云连通性测试，需配合query_id参数一起查询。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum OVERVIEW for value: overview
            /// </summary>
            public static readonly TypeEnum OVERVIEW = new TypeEnum("overview");

            /// <summary>
            /// Enum DETAIL for value: detail
            /// </summary>
            public static readonly TypeEnum DETAIL = new TypeEnum("detail");

            /// <summary>
            /// Enum NETWORK for value: network
            /// </summary>
            public static readonly TypeEnum NETWORK = new TypeEnum("network");

            /// <summary>
            /// Enum PRECHECK for value: precheck
            /// </summary>
            public static readonly TypeEnum PRECHECK = new TypeEnum("precheck");

            /// <summary>
            /// Enum PROGRESS for value: progress
            /// </summary>
            public static readonly TypeEnum PROGRESS = new TypeEnum("progress");

            /// <summary>
            /// Enum LOG for value: log
            /// </summary>
            public static readonly TypeEnum LOG = new TypeEnum("log");

            /// <summary>
            /// Enum COMPARE for value: compare
            /// </summary>
            public static readonly TypeEnum COMPARE = new TypeEnum("compare");

            /// <summary>
            /// Enum FILE for value: file
            /// </summary>
            public static readonly TypeEnum FILE = new TypeEnum("file");

            /// <summary>
            /// Enum IS_WRITABLE for value: is_writable
            /// </summary>
            public static readonly TypeEnum IS_WRITABLE = new TypeEnum("is_writable");

            /// <summary>
            /// Enum CLOUD_CONNECTION for value: cloud_connection
            /// </summary>
            public static readonly TypeEnum CLOUD_CONNECTION = new TypeEnum("cloud_connection");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "overview", OVERVIEW },
                { "detail", DETAIL },
                { "network", NETWORK },
                { "precheck", PRECHECK },
                { "progress", PROGRESS },
                { "log", LOG },
                { "compare", COMPARE },
                { "file", FILE },
                { "is_writable", IS_WRITABLE },
                { "cloud_connection", CLOUD_CONNECTION },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 对比任务类型 - object_compare：对象对比。 - line_compare：行对比。 - content_compare：内容对比。 - data_compare：数据对比。
        /// </summary>
        /// <value>对比任务类型 - object_compare：对象对比。 - line_compare：行对比。 - content_compare：内容对比。 - data_compare：数据对比。</value>
        [JsonConverter(typeof(EnumClassConverter<CompareTypeEnum>))]
        public class CompareTypeEnum
        {
            /// <summary>
            /// Enum OBJECT_COMPARE for value: object_compare
            /// </summary>
            public static readonly CompareTypeEnum OBJECT_COMPARE = new CompareTypeEnum("object_compare");

            /// <summary>
            /// Enum LINE_COMPARE for value: line_compare
            /// </summary>
            public static readonly CompareTypeEnum LINE_COMPARE = new CompareTypeEnum("line_compare");

            /// <summary>
            /// Enum CONTENT_COMPARE for value: content_compare
            /// </summary>
            public static readonly CompareTypeEnum CONTENT_COMPARE = new CompareTypeEnum("content_compare");

            /// <summary>
            /// Enum DATA_COMPARE for value: data_compare
            /// </summary>
            public static readonly CompareTypeEnum DATA_COMPARE = new CompareTypeEnum("data_compare");

            private static readonly Dictionary<string, CompareTypeEnum> StaticFields =
            new Dictionary<string, CompareTypeEnum>()
            {
                { "object_compare", OBJECT_COMPARE },
                { "line_compare", LINE_COMPARE },
                { "content_compare", CONTENT_COMPARE },
                { "data_compare", DATA_COMPARE },
            };

            private string _value;

            public CompareTypeEnum()
            {

            }

            public CompareTypeEnum(string value)
            {
                _value = value;
            }

            public static CompareTypeEnum FromValue(string value)
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

                if (this.Equals(obj as CompareTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CompareTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CompareTypeEnum a, CompareTypeEnum b)
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

            public static bool operator !=(CompareTypeEnum a, CompareTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 查询对比内容。取值： - overview：对比任务概览。 - list：数据对比任务列表。 - detail：对比详情。 - diff：不一致详情。
        /// </summary>
        /// <value>查询对比内容。取值： - overview：对比任务概览。 - list：数据对比任务列表。 - detail：对比详情。 - diff：不一致详情。</value>
        [JsonConverter(typeof(EnumClassConverter<QueryTypeEnum>))]
        public class QueryTypeEnum
        {
            /// <summary>
            /// Enum OVERVIEW for value: overview
            /// </summary>
            public static readonly QueryTypeEnum OVERVIEW = new QueryTypeEnum("overview");

            /// <summary>
            /// Enum LIST for value: list
            /// </summary>
            public static readonly QueryTypeEnum LIST = new QueryTypeEnum("list");

            /// <summary>
            /// Enum DETAIL for value: detail
            /// </summary>
            public static readonly QueryTypeEnum DETAIL = new QueryTypeEnum("detail");

            /// <summary>
            /// Enum DIFF for value: diff
            /// </summary>
            public static readonly QueryTypeEnum DIFF = new QueryTypeEnum("diff");

            private static readonly Dictionary<string, QueryTypeEnum> StaticFields =
            new Dictionary<string, QueryTypeEnum>()
            {
                { "overview", OVERVIEW },
                { "list", LIST },
                { "detail", DETAIL },
                { "diff", DIFF },
            };

            private string _value;

            public QueryTypeEnum()
            {

            }

            public QueryTypeEnum(string value)
            {
                _value = value;
            }

            public static QueryTypeEnum FromValue(string value)
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

                if (this.Equals(obj as QueryTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(QueryTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(QueryTypeEnum a, QueryTypeEnum b)
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

            public static bool operator !=(QueryTypeEnum a, QueryTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 查询对象对比详情类型。取值： - DB：库级对比详情。 - TABLE：表级对比详情。 - INDEX：索引对比详情。
        /// </summary>
        /// <value>查询对象对比详情类型。取值： - DB：库级对比详情。 - TABLE：表级对比详情。 - INDEX：索引对比详情。</value>
        [JsonConverter(typeof(EnumClassConverter<ObjectTypeEnum>))]
        public class ObjectTypeEnum
        {
            /// <summary>
            /// Enum DB for value: DB
            /// </summary>
            public static readonly ObjectTypeEnum DB = new ObjectTypeEnum("DB");

            /// <summary>
            /// Enum TABLE for value: TABLE
            /// </summary>
            public static readonly ObjectTypeEnum TABLE = new ObjectTypeEnum("TABLE");

            /// <summary>
            /// Enum INDEX for value: INDEX
            /// </summary>
            public static readonly ObjectTypeEnum INDEX = new ObjectTypeEnum("INDEX");

            private static readonly Dictionary<string, ObjectTypeEnum> StaticFields =
            new Dictionary<string, ObjectTypeEnum>()
            {
                { "DB", DB },
                { "TABLE", TABLE },
                { "INDEX", INDEX },
            };

            private string _value;

            public ObjectTypeEnum()
            {

            }

            public ObjectTypeEnum(string value)
            {
                _value = value;
            }

            public static ObjectTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ObjectTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ObjectTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ObjectTypeEnum a, ObjectTypeEnum b)
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

            public static bool operator !=(ObjectTypeEnum a, ObjectTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 对比结果类型。取值： - compare：对比完成。 - uncompare：无法对比。
        /// </summary>
        /// <value>对比结果类型。取值： - compare：对比完成。 - uncompare：无法对比。</value>
        [JsonConverter(typeof(EnumClassConverter<CompareDetailTypeEnum>))]
        public class CompareDetailTypeEnum
        {
            /// <summary>
            /// Enum COMPARE for value: compare
            /// </summary>
            public static readonly CompareDetailTypeEnum COMPARE = new CompareDetailTypeEnum("compare");

            /// <summary>
            /// Enum UNCOMPARE for value: uncompare
            /// </summary>
            public static readonly CompareDetailTypeEnum UNCOMPARE = new CompareDetailTypeEnum("uncompare");

            private static readonly Dictionary<string, CompareDetailTypeEnum> StaticFields =
            new Dictionary<string, CompareDetailTypeEnum>()
            {
                { "compare", COMPARE },
                { "uncompare", UNCOMPARE },
            };

            private string _value;

            public CompareDetailTypeEnum()
            {

            }

            public CompareDetailTypeEnum(string value)
            {
                _value = value;
            }

            public static CompareDetailTypeEnum FromValue(string value)
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

                if (this.Equals(obj as CompareDetailTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CompareDetailTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CompareDetailTypeEnum a, CompareDetailTypeEnum b)
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

            public static bool operator !=(CompareDetailTypeEnum a, CompareDetailTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 任务ID。
        /// </summary>
        [SDKProperty("job_id", IsPath = true)]
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 请求语言类型。
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public XLanguageEnum XLanguage { get; set; }
        /// <summary>
        /// 任务详情类型。取值： - overview：任务概览信息。 - detail：任务基本信息。 - network：测试连接结果信息，需配合query_id参数一起查询。 - precheck：预检查结果信息，需配合query_id参数一起查询。 - progress：任务进度信息。 - log：任务日志信息，支持分页查询参数offset与limit。 - compare：查询对比任务。 - file：对象导入信息。 - is_writable：目标库解除只读结果。 - cloud_connection：录制回放他云连通性测试，需配合query_id参数一起查询。
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 通过指定Query ID查询任务详情。  说明：部分type类型的任务详情，需要通过触发该操作的请求返回的query_id进行操作结果查询。
        /// </summary>
        [SDKProperty("query_id", IsQuery = true)]
        [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryId { get; set; }

        /// <summary>
        /// 偏移量，表示查询该偏移量后面的记录。  说明：部分type类型的任务详情支持分页查询，可以通过传递该参数进行分页控制。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询返回记录的数量限制。  说明：部分type类型的任务详情支持分页查询，可以通过传递该参数进行分页控制。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 对比任务类型 - object_compare：对象对比。 - line_compare：行对比。 - content_compare：内容对比。 - data_compare：数据对比。
        /// </summary>
        [SDKProperty("compare_type", IsQuery = true)]
        [JsonProperty("compare_type", NullValueHandling = NullValueHandling.Ignore)]
        public CompareTypeEnum CompareType { get; set; }
        /// <summary>
        /// 查询对比内容。取值： - overview：对比任务概览。 - list：数据对比任务列表。 - detail：对比详情。 - diff：不一致详情。
        /// </summary>
        [SDKProperty("query_type", IsQuery = true)]
        [JsonProperty("query_type", NullValueHandling = NullValueHandling.Ignore)]
        public QueryTypeEnum QueryType { get; set; }
        /// <summary>
        /// 查询对象对比详情类型。取值： - DB：库级对比详情。 - TABLE：表级对比详情。 - INDEX：索引对比详情。
        /// </summary>
        [SDKProperty("object_type", IsQuery = true)]
        [JsonProperty("object_type", NullValueHandling = NullValueHandling.Ignore)]
        public ObjectTypeEnum ObjectType { get; set; }
        /// <summary>
        /// 对比任务ID。
        /// </summary>
        [SDKProperty("compare_task_id", IsQuery = true)]
        [JsonProperty("compare_task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CompareTaskId { get; set; }

        /// <summary>
        /// 数据对比源库名称。
        /// </summary>
        [SDKProperty("source_db_name", IsQuery = true)]
        [JsonProperty("source_db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDbName { get; set; }

        /// <summary>
        /// 数据对比目标库名称。
        /// </summary>
        [SDKProperty("target_db_name", IsQuery = true)]
        [JsonProperty("target_db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetDbName { get; set; }

        /// <summary>
        /// 对比结果类型。取值： - compare：对比完成。 - uncompare：无法对比。
        /// </summary>
        [SDKProperty("compare_detail_type", IsQuery = true)]
        [JsonProperty("compare_detail_type", NullValueHandling = NullValueHandling.Ignore)]
        public CompareDetailTypeEnum CompareDetailType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowJobDetailRequest {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  queryId: ").Append(QueryId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  compareType: ").Append(CompareType).Append("\n");
            sb.Append("  queryType: ").Append(QueryType).Append("\n");
            sb.Append("  objectType: ").Append(ObjectType).Append("\n");
            sb.Append("  compareTaskId: ").Append(CompareTaskId).Append("\n");
            sb.Append("  sourceDbName: ").Append(SourceDbName).Append("\n");
            sb.Append("  targetDbName: ").Append(TargetDbName).Append("\n");
            sb.Append("  compareDetailType: ").Append(CompareDetailType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowJobDetailRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowJobDetailRequest input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.XLanguage != input.XLanguage) return false;
            if (this.Type != input.Type) return false;
            if (this.QueryId != input.QueryId || (this.QueryId != null && !this.QueryId.Equals(input.QueryId))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.CompareType != input.CompareType) return false;
            if (this.QueryType != input.QueryType) return false;
            if (this.ObjectType != input.ObjectType) return false;
            if (this.CompareTaskId != input.CompareTaskId || (this.CompareTaskId != null && !this.CompareTaskId.Equals(input.CompareTaskId))) return false;
            if (this.SourceDbName != input.SourceDbName || (this.SourceDbName != null && !this.SourceDbName.Equals(input.SourceDbName))) return false;
            if (this.TargetDbName != input.TargetDbName || (this.TargetDbName != null && !this.TargetDbName.Equals(input.TargetDbName))) return false;
            if (this.CompareDetailType != input.CompareDetailType) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.QueryId != null) hashCode = hashCode * 59 + this.QueryId.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                hashCode = hashCode * 59 + this.CompareType.GetHashCode();
                hashCode = hashCode * 59 + this.QueryType.GetHashCode();
                hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.CompareTaskId != null) hashCode = hashCode * 59 + this.CompareTaskId.GetHashCode();
                if (this.SourceDbName != null) hashCode = hashCode * 59 + this.SourceDbName.GetHashCode();
                if (this.TargetDbName != null) hashCode = hashCode * 59 + this.TargetDbName.GetHashCode();
                hashCode = hashCode * 59 + this.CompareDetailType.GetHashCode();
                return hashCode;
            }
        }
    }
}
