//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.18.5
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	// Mixin Content Type with alias "contactFromControls"
	/// <summary>Contact From Controls</summary>
	public partial interface IContactFromControls : IPublishedContent
	{
		/// <summary>Error Message</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		global::System.Web.IHtmlString ErrorMessage { get; }

		/// <summary>Success Message</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		global::System.Web.IHtmlString SuccessMessage { get; }
	}

	/// <summary>Contact From Controls</summary>
	[PublishedModel("contactFromControls")]
	public partial class ContactFromControls : PublishedContentModel, IContactFromControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public new const string ModelTypeAlias = "contactFromControls";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContactFromControls, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ContactFromControls(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Error Message: Enter the message to show on error
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("errorMessage")]
		public virtual global::System.Web.IHtmlString ErrorMessage => GetErrorMessage(this);

		/// <summary>Static getter for Error Message</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public static global::System.Web.IHtmlString GetErrorMessage(IContactFromControls that) => that.Value<global::System.Web.IHtmlString>("errorMessage");

		///<summary>
		/// Success Message: Enter the success message to show on success
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("successMessage")]
		public virtual global::System.Web.IHtmlString SuccessMessage => GetSuccessMessage(this);

		/// <summary>Static getter for Success Message</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public static global::System.Web.IHtmlString GetSuccessMessage(IContactFromControls that) => that.Value<global::System.Web.IHtmlString>("successMessage");
	}
}
