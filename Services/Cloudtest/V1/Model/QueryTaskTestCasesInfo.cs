using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class QueryTaskTestCasesInfo 
    {

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("page_no", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNo { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 起始位
        /// </summary>
        [JsonProperty("start_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartIndex { get; set; }

        /// <summary>
        /// 结束位
        /// </summary>
        [JsonProperty("end_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? EndIndex { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        [JsonProperty("key_word", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyWord { get; set; }

        /// <summary>
        /// 用例uri列表
        /// </summary>
        [JsonProperty("test_case_uris", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TestCaseUris { get; set; }

        /// <summary>
        /// 测试计划uri
        /// </summary>
        [JsonProperty("iterator_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string IteratorUri { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryTaskTestCasesInfo {\n");
            sb.Append("  pageNo: ").Append(PageNo).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  startIndex: ").Append(StartIndex).Append("\n");
            sb.Append("  endIndex: ").Append(EndIndex).Append("\n");
            sb.Append("  keyWord: ").Append(KeyWord).Append("\n");
            sb.Append("  testCaseUris: ").Append(TestCaseUris).Append("\n");
            sb.Append("  iteratorUri: ").Append(IteratorUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryTaskTestCasesInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryTaskTestCasesInfo input)
        {
            if (input == null) return false;
            if (this.PageNo != input.PageNo || (this.PageNo != null && !this.PageNo.Equals(input.PageNo))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.StartIndex != input.StartIndex || (this.StartIndex != null && !this.StartIndex.Equals(input.StartIndex))) return false;
            if (this.EndIndex != input.EndIndex || (this.EndIndex != null && !this.EndIndex.Equals(input.EndIndex))) return false;
            if (this.KeyWord != input.KeyWord || (this.KeyWord != null && !this.KeyWord.Equals(input.KeyWord))) return false;
            if (this.TestCaseUris != input.TestCaseUris || (this.TestCaseUris != null && input.TestCaseUris != null && !this.TestCaseUris.SequenceEqual(input.TestCaseUris))) return false;
            if (this.IteratorUri != input.IteratorUri || (this.IteratorUri != null && !this.IteratorUri.Equals(input.IteratorUri))) return false;

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
                if (this.PageNo != null) hashCode = hashCode * 59 + this.PageNo.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.StartIndex != null) hashCode = hashCode * 59 + this.StartIndex.GetHashCode();
                if (this.EndIndex != null) hashCode = hashCode * 59 + this.EndIndex.GetHashCode();
                if (this.KeyWord != null) hashCode = hashCode * 59 + this.KeyWord.GetHashCode();
                if (this.TestCaseUris != null) hashCode = hashCode * 59 + this.TestCaseUris.GetHashCode();
                if (this.IteratorUri != null) hashCode = hashCode * 59 + this.IteratorUri.GetHashCode();
                return hashCode;
            }
        }
    }
}
