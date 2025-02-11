﻿namespace AbcDataOpsExtTests.ISie.String;

public class Demo : Setup.Arrange
{
    [SyntaxDemo]
    public void Shortcuts() {
        True = NullStr.Is().NullOrEmpty;

        True = string.Empty.Is().NullOrEmpty;
        False = "D".Is().NullOrEmpty;

        True = string.Empty.Is().NullEmptyOr.Whitespace;
        False = string.Empty.Is().Whitespace;

        True = "  \n  ".Is().NullEmptyOr.Whitespace;

        True = "  \n  ".Is().EmptyOr.Whitespace; // must be exception
        _ = NullStr.Is().EmptyOr.Whitespace; // must be exception
    }

    [SyntaxDemo]
    public void Blank() {
        False = string.Empty.Is().Spaces;
        True = space.Single.Is().Spaces;
        True = "    ".Is().Spaces;
        False = "  \n  ".Is().Spaces;

        False = string.Empty.Is().SingleSpace;
        True = space.Single.Is().SingleSpace;
        False = "       ".Is().SingleSpace;

        True = "not whitespace".Is().EmptyOr.Whitespace;

        True = space.Single.Is().EmptyOr.Spaces;
        False = "       ".Is().SingleSpace;

        _ = "text".Is().NullEmptyOr.Whitespace;
        _ = "text".Is().NullEmptyOr.Spaces;
        False = "text".Is().NullEmptyOr.SingleSpace;
    }

    [SyntaxDemo]
    public void Grayspace() {
        False = string.Empty.Is().Grayspace;
    }

    [SyntaxDemo]
    public void Space() {
        _ = "text".Is().EmptyOr.Whitespace;
        _ = "text".Is().EmptyOr.Spaces;
        False = "text".Is().EmptyOr.SingleSpace;
    }

    [SyntaxDemo]
    public void InvalidCallsCheck() {
        //_ = "  \n  ".Is().NullEmptyOr.EmptyOr; // 🚫 Invalid semantics
        //_ = "text".Is().NullOr; // 🚫 Invalid Call !

        //_ = "text".Is().NullEmptyOr.Printable; // 🚫 Invalid Call !
        //_ = "text".Is().EmptyOr.Printable; // 🚫 Invalid Call !

        //_ = "text".Is().NullOrEmpty.Whitespace; // 🚫 Invalid Call !
    }

    // INVALID CAST
    [SyntaxDemo]
    public void InvalidCast() {
        _ = "test".Is().NullEmptyOr; // intermediate
        //bool result = "test".Is().NullEmptyOr;  // 🚫 Invalid cast !
        _ = "test".Is().EmptyOr;  // intermediate
        // bool result = "test".Is().EmptyOr;  // 🚫 Invalid cast !
    }
}
