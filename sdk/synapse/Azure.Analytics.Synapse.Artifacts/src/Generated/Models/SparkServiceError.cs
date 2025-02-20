// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The SparkServiceError. </summary>
    public partial class SparkServiceError
    {
        /// <summary> Initializes a new instance of SparkServiceError. </summary>
        internal SparkServiceError()
        {
        }

        /// <summary> Initializes a new instance of SparkServiceError. </summary>
        /// <param name="message"></param>
        /// <param name="errorCode"></param>
        /// <param name="source"></param>
        internal SparkServiceError(string message, string errorCode, SparkErrorSource? source)
        {
            Message = message;
            ErrorCode = errorCode;
            Source = source;
        }

        public string Message { get; }
        public string ErrorCode { get; }
        public SparkErrorSource? Source { get; }
    }
}
