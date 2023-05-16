﻿using Abc.Coll.Gtor;
using Abc.Mk.Coll;

namespace Test_Learn.Abc.Coll.Create;
public class CreationTests
{
    [Test]
    public void Instantiate() {
        var emptyColl = new ListAccu<object>();

        var semaphore = new ListAccu<bool>();
        semaphore.Add(true); semaphore.Add(false);

        var nums = new ListAccu<int>();
        nums.Add(1, 2, 3);

        var words = new ListAccu<string>();
        words.Add(Providers.LoremIpsum_SplitToWords);
    }

    [Test, TestCaseSource(typeof(Providers), nameof(Providers.ItemsAccuBuilders))]
    public void Build(IAdjustedItemsBuilder builder) {
        var emptyColl = builder.Of<object>();

        var semaphore = builder.Of(true);
        semaphore.Add(false);

        var nums = builder.Of(1, 2, 3);

        var words = builder.Of(Providers.LoremIpsum_SplitToWords);
    }
}



