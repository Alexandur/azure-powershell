// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401
{
    using Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.PowerShell;

    /// <summary>Storage REST API operation definition.</summary>
    [System.ComponentModel.TypeConverter(typeof(OperationAutoGeneratedTypeConverter))]
    public partial class OperationAutoGenerated
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.OperationAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGenerated" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGenerated DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new OperationAutoGenerated(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.OperationAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGenerated" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGenerated DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new OperationAutoGenerated(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="OperationAutoGenerated" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="OperationAutoGenerated" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGenerated FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.OperationAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal OperationAutoGenerated(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Display"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).Display = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationDisplay) content.GetValueForProperty("Display",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).Display, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.OperationDisplayTypeConverter.ConvertFrom);
            }
            if (content.Contains("OperationProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).OperationProperty = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationProperties) content.GetValueForProperty("OperationProperty",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).OperationProperty, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.OperationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Origin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).Origin = (string) content.GetValueForProperty("Origin",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).Origin, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayProvider"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).DisplayProvider = (string) content.GetValueForProperty("DisplayProvider",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).DisplayProvider, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayResource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).DisplayResource = (string) content.GetValueForProperty("DisplayResource",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).DisplayResource, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).DisplayOperation = (string) content.GetValueForProperty("DisplayOperation",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).DisplayOperation, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).DisplayDescription = (string) content.GetValueForProperty("DisplayDescription",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).DisplayDescription, global::System.Convert.ToString);
            }
            if (content.Contains("OperationPropertyServiceSpecification"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).OperationPropertyServiceSpecification = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IServiceSpecificationAutoGenerated) content.GetValueForProperty("OperationPropertyServiceSpecification",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).OperationPropertyServiceSpecification, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ServiceSpecificationAutoGeneratedTypeConverter.ConvertFrom);
            }
            if (content.Contains("ServiceSpecificationMetricSpecification"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).ServiceSpecificationMetricSpecification = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGenerated[]) content.GetValueForProperty("ServiceSpecificationMetricSpecification",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).ServiceSpecificationMetricSpecification, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGenerated>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.MetricSpecificationAutoGeneratedTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.OperationAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal OperationAutoGenerated(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Display"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).Display = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationDisplay) content.GetValueForProperty("Display",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).Display, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.OperationDisplayTypeConverter.ConvertFrom);
            }
            if (content.Contains("OperationProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).OperationProperty = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationProperties) content.GetValueForProperty("OperationProperty",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).OperationProperty, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.OperationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Origin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).Origin = (string) content.GetValueForProperty("Origin",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).Origin, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayProvider"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).DisplayProvider = (string) content.GetValueForProperty("DisplayProvider",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).DisplayProvider, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayResource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).DisplayResource = (string) content.GetValueForProperty("DisplayResource",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).DisplayResource, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).DisplayOperation = (string) content.GetValueForProperty("DisplayOperation",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).DisplayOperation, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).DisplayDescription = (string) content.GetValueForProperty("DisplayDescription",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).DisplayDescription, global::System.Convert.ToString);
            }
            if (content.Contains("OperationPropertyServiceSpecification"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).OperationPropertyServiceSpecification = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IServiceSpecificationAutoGenerated) content.GetValueForProperty("OperationPropertyServiceSpecification",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).OperationPropertyServiceSpecification, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ServiceSpecificationAutoGeneratedTypeConverter.ConvertFrom);
            }
            if (content.Contains("ServiceSpecificationMetricSpecification"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).ServiceSpecificationMetricSpecification = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGenerated[]) content.GetValueForProperty("ServiceSpecificationMetricSpecification",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IOperationAutoGeneratedInternal)this).ServiceSpecificationMetricSpecification, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGenerated>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.MetricSpecificationAutoGeneratedTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Storage REST API operation definition.
    [System.ComponentModel.TypeConverter(typeof(OperationAutoGeneratedTypeConverter))]
    public partial interface IOperationAutoGenerated

    {

    }
}