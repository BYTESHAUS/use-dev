﻿using AbcExtNUnit.Attributes.Case;

namespace ISie_Eval.BuiltinTypes.String.Tests;
public class MiscSpaces : Setup.Arrange
{
    [AbcExtNUnit.Attributes.Case.Test]
    public void SingleSpace() {
        True = " ".Is().SingleSpace;
        True = " ".Is().EmptyOr.SingleSpace;
        True = " ".Is().NullEmptyOr.SingleSpace;

        False = "".Is().SingleSpace;
        False = "  ".Is().SingleSpace;
    }

    [Many(" ", spaces.Single, "       ", "   ", "                     ")]
    public void AnySpaces(string subj) {
        True = subj.Is().Spaces;
        True = subj.Is().EmptyOr.Spaces;
        True = subj.Is().NullEmptyOr.Spaces;
    }

    [Many($" \u2029  ", "   test    ", " %  ", "      __            ")] // \u2029 = paragraph
    public void Not_AnySpaces(string subj) {

        TestBy(subj, false);
    }

    protected void TestBy(string subj, bool expected) {
        //Eq[expected] = true;
        Assert.That(subj.Is().Spaces, Is.EqualTo(expected));
        Assert.That(subj.Is().EmptyOr.Spaces, Is.EqualTo(expected));
        Assert.That(subj.Is().NullEmptyOr.Spaces, Is.EqualTo(expected));
    }
}