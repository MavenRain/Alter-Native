// 
// CSharpFormattingOptions.cs
//  
// Author:
//       Mike Krüger <mkrueger@novell.com>
//  
// Copyright (c) 2009 Novell, Inc (http://www.novell.com)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Reflection;
using System.Linq;

namespace ICSharpCode.NRefactory.Cpp
{
	public enum BraceStyle
	{
		DoNotChange,
		EndOfLine,
		EndOfLineWithoutSpace,
		NextLine,
		NextLineShifted,
		NextLineShifted2
	}

	public enum BraceForcement
	{
		DoNotChange,
		RemoveBraces,
		AddBraces
	}

	public enum ArrayInitializerPlacement
	{
		AlwaysNewLine,
		AlwaysSameLine
	}

	public enum PropertyFormatting
	{
		AllowOneLine,
		ForceOneLine,
		ForceNewLine
	}

	public class CppFormattingOptions
	{
		public string Name {
			get;
			set;
		}

		public bool IsBuiltIn {
			get;
			set;
		}

		public CppFormattingOptions Clone ()
		{
			return (CppFormattingOptions)MemberwiseClone ();
		}

		#region Indentation
		public bool IndentNamespaceBody { // tested
			get;
			set;
		}

		public bool IndentClassBody { // tested
			get;
			set;
		}

		public bool IndentInterfaceBody { // tested
			get;
			set;
		}

		public bool IndentStructBody { // tested
			get;
			set;
		}

		public bool IndentEnumBody { // tested
			get;
			set;
		}

		public bool IndentMethodBody { // tested
			get;
			set;
		}

		public bool IndentPropertyBody { // tested
			get;
			set;
		}

		public bool IndentEventBody { // tested
			get;
			set;
		}

		public bool IndentBlocks { // tested
			get;
			set;
		}

		public bool IndentSwitchBody { // tested
			get;
			set;
		}

		public bool IndentCaseBody { // tested
			get;
			set;
		}

		public bool IndentBreakStatements { // tested
			get;
			set;
		}

		public bool AlignEmbeddedUsingStatements { // tested
			get;
			set;
		}

		public bool AlignEmbeddedIfStatements { // tested
			get;
			set;
		}

		public PropertyFormatting PropertyFormatting { // tested
			get;
			set;
		}

		#endregion
		
		#region Braces
		public BraceStyle NamespaceBraceStyle { // tested
			get;
			set;
		}

		public BraceStyle ClassBraceStyle { // tested
			get;
			set;
		}

		public BraceStyle InterfaceBraceStyle { // tested
			get;
			set;
		}

		public BraceStyle StructBraceStyle { // tested
			get;
			set;
		}

		public BraceStyle EnumBraceStyle { // tested
			get;
			set;
		}

		public BraceStyle MethodBraceStyle { // tested
			get;
			set;
		}

		public BraceStyle AnonymousMethodBraceStyle {
			get;
			set;
		}

		public BraceStyle ConstructorBraceStyle {  // tested
			get;
			set;
		}

		public BraceStyle DestructorBraceStyle { // tested
			get;
			set;
		}

		public BraceStyle PropertyBraceStyle { // tested
			get;
			set;
		}

		public BraceStyle PropertyGetBraceStyle { // tested
			get;
			set;
		}

		public BraceStyle PropertySetBraceStyle { // tested
			get;
			set;
		}

		public bool AllowPropertyGetBlockInline { // tested
			get;
			set;
		}

		public bool AllowPropertySetBlockInline { // tested
			get;
			set;
		}

		public BraceStyle EventBraceStyle { // tested
			get;
			set;
		}

		public BraceStyle EventAddBraceStyle { // tested
			get;
			set;
		}

		public BraceStyle EventRemoveBraceStyle { // tested
			get;
			set;
		}

		public bool AllowEventAddBlockInline { // tested
			get;
			set;
		}

		public bool AllowEventRemoveBlockInline { // tested
			get;
			set;
		}

		public BraceStyle StatementBraceStyle { // tested
			get;
			set;
		}

		public bool AllowIfBlockInline {
			get;
			set;
		}

		#endregion
		
		#region Force Braces
		public BraceForcement IfElseBraceForcement { // tested
			get;
			set;
		}

		public BraceForcement ForBraceForcement { // tested
			get;
			set;
		}

		public BraceForcement ForEachBraceForcement { // tested
			get;
			set;
		}

		public BraceForcement WhileBraceForcement { // tested
			get;
			set;
		}

		public BraceForcement UsingBraceForcement { // tested
			get;
			set;
		}

		public BraceForcement FixedBraceForcement { // tested
			get;
			set;
		}

		#endregion
		
		#region NewLines
		public bool PlaceElseOnNewLine { // tested
			get;
			set;
		}

		public bool PlaceElseIfOnNewLine { // tested
			get;
			set;
		}

		public bool PlaceCatchOnNewLine { // tested
			get;
			set;
		}

		public bool PlaceFinallyOnNewLine { // tested
			get;
			set;
		}

		public bool PlaceWhileOnNewLine { // tested
			get;
			set;
		}

		public ArrayInitializerPlacement PlaceArrayInitializersOnNewLine {
			get;
			set;
		}
		#endregion
		
		#region Spaces
		// Methods
		public bool SpaceBeforeMethodDeclarationParentheses { // tested
			get;
			set;
		}

		public bool SpaceBetweenEmptyMethodDeclarationParentheses {
			get;
			set;
		}

		public bool SpaceBeforeMethodDeclarationParameterComma { // tested
			get;
			set;
		}

		public bool SpaceAfterMethodDeclarationParameterComma { // tested
			get;
			set;
		}

		public bool SpaceWithinMethodDeclarationParentheses { // tested
			get;
			set;
		}
		
		// Method calls
		public bool SpaceBeforeMethodCallParentheses { // tested
			get;
			set;
		}

		public bool SpaceBetweenEmptyMethodCallParentheses { // tested
			get;
			set;
		}

		public bool SpaceBeforeMethodCallParameterComma { // tested
			get;
			set;
		}

		public bool SpaceAfterMethodCallParameterComma { // tested
			get;
			set;
		}

		public bool SpaceWithinMethodCallParentheses { // tested
			get;
			set;
		}
		
		// fields
		
		public bool SpaceBeforeFieldDeclarationComma { // tested
			get;
			set;
		}

		public bool SpaceAfterFieldDeclarationComma { // tested
			get;
			set;
		}
		
		// local variables
		
		public bool SpaceBeforeLocalVariableDeclarationComma { // tested
			get;
			set;
		}

		public bool SpaceAfterLocalVariableDeclarationComma { // tested
			get;
			set;
		}
		
		// constructors
		
		public bool SpaceBeforeConstructorDeclarationParentheses { // tested
			get;
			set;
		}

		public bool SpaceBetweenEmptyConstructorDeclarationParentheses { // tested
			get;
			set;
		}

		public bool SpaceBeforeConstructorDeclarationParameterComma { // tested
			get;
			set;
		}

		public bool SpaceAfterConstructorDeclarationParameterComma { // tested
			get;
			set;
		}

		public bool SpaceWithinConstructorDeclarationParentheses { // tested
			get;
			set;
		}
		
		// indexer
		public bool SpaceBeforeIndexerDeclarationBracket { // tested
			get;
			set;
		}

		public bool SpaceWithinIndexerDeclarationBracket { // tested
			get;
			set;
		}

		public bool SpaceBeforeIndexerDeclarationParameterComma {
			get;
			set;
		}

		public bool SpaceAfterIndexerDeclarationParameterComma {
			get;
			set;
		}
		
		// delegates
		
		public bool SpaceBeforeDelegateDeclarationParentheses {
			get;
			set;
		}

		public bool SpaceBetweenEmptyDelegateDeclarationParentheses {
			get;
			set;
		}

		public bool SpaceBeforeDelegateDeclarationParameterComma {
			get;
			set;
		}

		public bool SpaceAfterDelegateDeclarationParameterComma {
			get;
			set;
		}

		public bool SpaceWithinDelegateDeclarationParentheses {
			get;
			set;
		}

		public bool SpaceBeforeNewParentheses { // tested
			get;
			set;
		}

		public bool SpaceBeforeIfParentheses { // tested
			get;
			set;
		}

		public bool SpaceBeforeWhileParentheses { // tested
			get;
			set;
		}

		public bool SpaceBeforeForParentheses { // tested
			get;
			set;
		}

		public bool SpaceBeforeForeachParentheses { // tested
			get;
			set;
		}

		public bool SpaceBeforeCatchParentheses { // tested
			get;
			set;
		}

		public bool SpaceBeforeSwitchParentheses { // tested
			get;
			set;
		}

		public bool SpaceBeforeLockParentheses { // tested
			get;
			set;
		}

		public bool SpaceBeforeUsingParentheses { // tested
			get;
			set;
		}

		public bool SpaceAroundAssignment { // tested
			get;
			set;
		}

		public bool SpaceAroundLogicalOperator { // tested
			get;
			set;
		}

		public bool SpaceAroundEqualityOperator { // tested
			get;
			set;
		}

		public bool SpaceAroundRelationalOperator { // tested
			get;
			set;
		}

		public bool SpaceAroundBitwiseOperator { // tested
			get;
			set;
		}

		public bool SpaceAroundAdditiveOperator { // tested
			get;
			set;
		}

		public bool SpaceAroundMultiplicativeOperator { // tested
			get;
			set;
		}

		public bool SpaceAroundShiftOperator { // tested
			get;
			set;
		}

		public bool SpaceAroundNullCoalescingOperator {
			get;
			set;
		}

		public bool SpacesWithinParentheses { // tested
			get;
			set;
		}

		public bool SpacesWithinIfParentheses { // tested
			get;
			set;
		}

		public bool SpacesWithinWhileParentheses { // tested
			get;
			set;
		}

		public bool SpacesWithinForParentheses { // tested
			get;
			set;
		}

		public bool SpacesWithinForeachParentheses { // tested
			get;
			set;
		}

		public bool SpacesWithinCatchParentheses { // tested
			get;
			set;
		}

		public bool SpacesWithinSwitchParentheses { // tested
			get;
			set;
		}

		public bool SpacesWithinLockParentheses { // tested
			get;
			set;
		}

		public bool SpacesWithinUsingParentheses { // tested
			get;
			set;
		}

		public bool SpacesWithinCastParentheses { // tested
			get;
			set;
		}

		public bool SpacesWithinSizeOfParentheses { // tested
			get;
			set;
		}

		public bool SpaceBeforeSizeOfParentheses { // tested
			get;
			set;
		}

		public bool SpacesWithinTypeOfParentheses { // tested
			get;
			set;
		}

		public bool SpacesWithinNewParentheses { // tested
			get;
			set;
		}

		public bool SpacesBetweenEmptyNewParentheses { // tested
			get;
			set;
		}

		public bool SpaceBeforeNewParameterComma { // tested
			get;
			set;
		}

		public bool SpaceAfterNewParameterComma { // tested
			get;
			set;
		}

		public bool SpaceBeforeTypeOfParentheses { // tested
			get;
			set;
		}

		public bool SpacesWithinCheckedExpressionParantheses { // tested
			get;
			set;
		}

		public bool SpaceBeforeConditionalOperatorCondition { // tested
			get;
			set;
		}

		public bool SpaceAfterConditionalOperatorCondition { // tested
			get;
			set;
		}

		public bool SpaceBeforeConditionalOperatorSeparator { // tested
			get;
			set;
		}

		public bool SpaceAfterConditionalOperatorSeparator { // tested
			get;
			set;
		}
		
		// brackets
		public bool SpacesWithinBrackets { // tested
			get;
			set;
		}

		public bool SpacesBeforeBrackets { // tested
			get;
			set;
		}

		public bool SpaceBeforeBracketComma { // tested
			get;
			set;
		}

		public bool SpaceAfterBracketComma { // tested
			get;
			set;
		}

		public bool SpaceBeforeForSemicolon { // tested
			get;
			set;
		}

		public bool SpaceAfterForSemicolon { // tested
			get;
			set;
		}

		public bool SpaceAfterTypecast { // tested
			get;
			set;
		}

		public bool SpaceBeforeArrayDeclarationBrackets { // tested
			get;
			set;
		}

		#endregion
		
		#region Blank Lines
		public int BlankLinesBeforeUsings {
			get;
			set;
		}

		public int BlankLinesAfterUsings {
			get;
			set;
		}

		public int BlankLinesBeforeFirstDeclaration {
			get;
			set;
		}

		public int BlankLinesBetweenTypes {
			get;
			set;
		}

		public int BlankLinesBetweenFields {
			get;
			set;
		}

		public int BlankLinesBetweenEventFields {
			get;
			set;
		}

		public int BlankLinesBetweenMembers {
			get;
			set;
		}

		#endregion
		
		public CppFormattingOptions ()
		{
			IndentNamespaceBody = true;
			IndentClassBody = IndentInterfaceBody = IndentStructBody = IndentEnumBody = true;
			IndentMethodBody = IndentPropertyBody = IndentEventBody = true;
			IndentBlocks = true;
			IndentSwitchBody = false;
			IndentCaseBody = true;
			IndentBreakStatements = true;
			NamespaceBraceStyle = BraceStyle.NextLine;
			ClassBraceStyle = InterfaceBraceStyle = StructBraceStyle = EnumBraceStyle = BraceStyle.NextLine;
			MethodBraceStyle = ConstructorBraceStyle = DestructorBraceStyle = BraceStyle.NextLine;
			AnonymousMethodBraceStyle = BraceStyle.NextLine;

			PropertyBraceStyle = PropertyGetBraceStyle = PropertySetBraceStyle = BraceStyle.EndOfLine;
			AllowPropertyGetBlockInline = AllowPropertySetBlockInline = true;

			EventBraceStyle = EventAddBraceStyle = EventRemoveBraceStyle = BraceStyle.EndOfLine;
			AllowEventAddBlockInline = AllowEventRemoveBlockInline = true;
			StatementBraceStyle = BraceStyle.EndOfLine;

			PlaceElseOnNewLine = false;
			PlaceCatchOnNewLine = false;
			PlaceFinallyOnNewLine = false;
			PlaceWhileOnNewLine = false;
			PlaceArrayInitializersOnNewLine = ArrayInitializerPlacement.AlwaysSameLine;

			SpaceBeforeMethodCallParentheses = false;
			SpaceBeforeMethodDeclarationParentheses = false;
			SpaceBeforeConstructorDeclarationParentheses = false;
			SpaceBeforeDelegateDeclarationParentheses = true;
			SpaceAfterMethodCallParameterComma = true;
			SpaceAfterConstructorDeclarationParameterComma = true;
			
			SpaceBeforeNewParentheses = true;
			SpacesWithinNewParentheses = false;
			SpacesBetweenEmptyNewParentheses = false;
			SpaceBeforeNewParameterComma = false;
			SpaceAfterNewParameterComma = true;
			
			SpaceBeforeIfParentheses = true;
			SpaceBeforeWhileParentheses = true;
			SpaceBeforeForParentheses = true;
			SpaceBeforeForeachParentheses = true;
			SpaceBeforeCatchParentheses = true;
			SpaceBeforeSwitchParentheses = true;
			SpaceBeforeLockParentheses = true; 
			SpaceBeforeUsingParentheses = true;
			SpaceAroundAssignment = true;
			SpaceAroundLogicalOperator = true;
			SpaceAroundEqualityOperator = true;
			SpaceAroundRelationalOperator = true;
			SpaceAroundBitwiseOperator = true;
			SpaceAroundAdditiveOperator = true;
			SpaceAroundMultiplicativeOperator = true;
			SpaceAroundShiftOperator = true;
			SpaceAroundNullCoalescingOperator = true;
			SpacesWithinParentheses = false;
			SpaceWithinMethodCallParentheses = false;
			SpaceWithinMethodDeclarationParentheses = false;
			SpacesWithinIfParentheses = false;
			SpacesWithinWhileParentheses = false;
			SpacesWithinForParentheses = false;
			SpacesWithinForeachParentheses = false;
			SpacesWithinCatchParentheses = false;
			SpacesWithinSwitchParentheses = false;
			SpacesWithinLockParentheses = false;
			SpacesWithinUsingParentheses = false;
			SpacesWithinCastParentheses = false;
			SpacesWithinSizeOfParentheses = false;
			SpacesWithinTypeOfParentheses = false;
			SpacesWithinCheckedExpressionParantheses = false;
			SpaceBeforeConditionalOperatorCondition = true;
			SpaceAfterConditionalOperatorCondition = true;
			SpaceBeforeConditionalOperatorSeparator = true;
			SpaceAfterConditionalOperatorSeparator = true;

			SpacesWithinBrackets = false;
			SpacesBeforeBrackets = true;
			SpaceBeforeBracketComma = false;
			SpaceAfterBracketComma = true;
					
			SpaceBeforeForSemicolon = false;
			SpaceAfterForSemicolon = true;
			SpaceAfterTypecast = false;
			
			AlignEmbeddedIfStatements = true;
			AlignEmbeddedUsingStatements = true;
			PropertyFormatting = PropertyFormatting.AllowOneLine;
			SpaceBeforeMethodDeclarationParameterComma = false;
			SpaceAfterMethodDeclarationParameterComma = true;
			SpaceBeforeFieldDeclarationComma = false;
			SpaceAfterFieldDeclarationComma = true;
			SpaceBeforeLocalVariableDeclarationComma = false;
			SpaceAfterLocalVariableDeclarationComma = true;
			
			SpaceBeforeIndexerDeclarationBracket = true;
			SpaceWithinIndexerDeclarationBracket = false;
			SpaceBeforeIndexerDeclarationParameterComma = false;
		
		
			SpaceAfterIndexerDeclarationParameterComma = true;
			
			BlankLinesBeforeUsings = 0;
			BlankLinesAfterUsings = 1;
			
			
			BlankLinesBeforeFirstDeclaration = 0;
			BlankLinesBetweenTypes = 1;
			BlankLinesBetweenFields = 0;
			BlankLinesBetweenEventFields = 0;
			BlankLinesBetweenMembers = 1;
		}
	}
}
