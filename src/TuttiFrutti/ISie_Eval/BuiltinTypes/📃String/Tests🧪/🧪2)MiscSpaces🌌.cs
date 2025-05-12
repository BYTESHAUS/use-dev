﻿using AbcExtNUnit.Attributes.Case;

namespace ISie_Eval.BuiltinTypes.String.Tests;
public class MiscSpaces : Arrange
{
    [Test]
    public void SingleSpace() {
        True = " ".Is.SingleSpace;
        False = " ".Not.SingleSpace;

        True = " ".Is.EmptyOr.SingleSpace;
        True = " ".Is.NullEmptyOr.SingleSpace;

        False = "".Is.SingleSpace;
        False = "  ".Is.SingleSpace;
        True = "  ".Not.SingleSpace;
    }

    [Many(" ", spaces.Single, "       ", "   ", "                     ")]
    public void AnySpaces(string subj) {
        True = subj.Is.Spaces;
        False = subj.Not.Spaces;
        True = subj.Is.EmptyOr.Spaces;
        True = subj.Is.NullEmptyOr.Spaces;
    }

    [Many($" \u2029  ", "   test    ", " %  ", "      __            ")] // \u2029 = paragraph
    public void Not_AnySpaces(string subj) {

        TestBy(subj, false);
    }

    protected void TestBy(string subj, bool expected) {
        Eq[expected] = subj.Is.Spaces;
        Eq[expected] = subj.Is.EmptyOr.Spaces;
        Eq[expected] = subj.Is.NullEmptyOr.Spaces;

        Not[expected] = subj.Not.Spaces;
        Not[expected] = subj.Not.EmptyOr.Spaces;
        Not[expected] = subj.Not.NullEmptyOr.Spaces;

    }
}