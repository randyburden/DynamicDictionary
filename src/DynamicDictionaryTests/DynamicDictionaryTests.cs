using System.Collections.Generic;
using NUnit.Framework;

namespace DynamicDictionaryTests
{
    [TestFixture]
    public class DynamicDictionaryTests
    {
        [Test]
        public void Accessing_A_Not_Existent_Property_Should_Return_Null()
        {
            dynamic obj = new DynamicDictionary.DynamicDictionary();

            var firstName = obj.FirstName;

            Assert.Null( firstName );
        }

        [Test]
        public void Accessing_A_Defined_Property_Should_Return_The_Defined_Value()
        {
            dynamic obj = new DynamicDictionary.DynamicDictionary();

            obj.FirstName = "Clark";

            Assert.That( obj.FirstName == "Clark" );
        }

        [Test]
        public void The_DynamicDictionary_Should_Be_Castable_To_An_IDictionary_Of_String_Object()
        {
            dynamic obj = new DynamicDictionary.DynamicDictionary();

            var dictionary = ( IDictionary<string, object> ) obj;

            Assert.NotNull( dictionary );
        }

        [Test]
        public void Properties_Defined_On_The_Dynamic_Should_Be_Accessible_When_Cast_To_A_Dictionary()
        {
            dynamic obj = new DynamicDictionary.DynamicDictionary();

            obj.FirstName = "Clark";

            var dictionary = (IDictionary<string, object>)obj;
            
            Assert.That( dictionary.ContainsKey( "FirstName" ) );

            Assert.That( dictionary["FirstName"].ToString() == "Clark" );
        }

        [Test]
        public void Properties_Defined_When_Cast_To_A_Dictionary_Should_Be_Accessible_When_Accessed_Dynamically()
        {
            dynamic obj = new DynamicDictionary.DynamicDictionary();
            
            var dictionary = (IDictionary<string, object>)obj;

            dictionary.Add( "FirstName", "Clark" );

            Assert.That( obj.FirstName == "Clark" );
        }

        [Test]
        public void Accessing_A_Defined_Property_Using_Different_Cases_Should_Return_The_Defined_Value()
        {
            dynamic obj = new DynamicDictionary.DynamicDictionary();

            obj.FirstName = "Clark";

            Assert.That( obj.FIRSTNAME == "Clark" );

            Assert.That( obj.firstname == "Clark" );

            Assert.That( obj.fIrStNaMe == "Clark" );
        }

        [Test]
        public void A_Defined_Anonymous_Object_Should_Be_Accessible_Dynamically()
        {
            dynamic obj = new DynamicDictionary.DynamicDictionary();

            obj.Customer = new { FirstName = "Clark", LastName = "Kent" };

            Assert.That( obj.Customer.FirstName == "Clark" );
        }
    }
}