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
    /// 数据过滤对象信息请求体  注意：           每张表仅支持添加一个校验规则。           数据过滤每次最多支持500张表。           过滤表达式不支持使用某种数据库引擎特有的package、函数、变量、常量等写法，须使用通用SQL标准。请直接输入SQL语句中WHERE之后的部分（不包含WHERE和分号，例如：sid &gt; 3 and sname like \&quot;G %\&quot;），最多支持输入512个字符。           过滤条件填写的SQL语句中，关键字需要用反引号，datatime类型（包含日期和时间）需要用单引号，例如：update &gt; &#39;2022-07-13 00:00:00&#39; and age &gt;10。           不支持对LOB字段设置过滤条件，如CLOB、BLOB、BYTEA等大字段类型。           不支持库名、表名带有换行符的对象设置过滤规则。           建议不要对非精确类型字段设置过滤条件，如FLOAT、DECIMAL、DOUBLE等。           建议不要对带有特殊字符的字段设置过滤条件。           不建议使用非幂等表达式或函数作为数据加工条件，如SYSTIMESTAMP，SYSDATE等，因其每次调用返回的结果可能会有差异，导致达不到预期。
    /// </summary>
    public class GeneralTransformationReq 
    {

        /// <summary>
        /// 数据过滤对象列表。包含需要校验的具体数据库对象（库/Schema/表）信息，在简单条件过滤场景下为必填项。列表中的每个元素代表一个待过滤的数据库对象。适用条件：简单过滤条件场景下必填。
        /// </summary>
        [JsonProperty("filter_object_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataFilterObjectInfo> FilterObjectList { get; set; }

        /// <summary>
        /// 源端数据库的过滤条件SQL语句。用于定义源库数据过滤规则，支持SQL子查询等高级过滤表达式。当数据过滤涉及子查询场景时，需要通过此字段配置查询条件。
        /// </summary>
        [JsonProperty("source_filter_condition", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceFilterCondition { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeneralTransformationReq {\n");
            sb.Append("  filterObjectList: ").Append(FilterObjectList).Append("\n");
            sb.Append("  sourceFilterCondition: ").Append(SourceFilterCondition).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GeneralTransformationReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GeneralTransformationReq input)
        {
            if (input == null) return false;
            if (this.FilterObjectList != input.FilterObjectList || (this.FilterObjectList != null && input.FilterObjectList != null && !this.FilterObjectList.SequenceEqual(input.FilterObjectList))) return false;
            if (this.SourceFilterCondition != input.SourceFilterCondition || (this.SourceFilterCondition != null && !this.SourceFilterCondition.Equals(input.SourceFilterCondition))) return false;

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
                if (this.FilterObjectList != null) hashCode = hashCode * 59 + this.FilterObjectList.GetHashCode();
                if (this.SourceFilterCondition != null) hashCode = hashCode * 59 + this.SourceFilterCondition.GetHashCode();
                return hashCode;
            }
        }
    }
}
