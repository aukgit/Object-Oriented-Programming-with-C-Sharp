namespace JumpStartOOP.ClassConcept.Generics {
    internal class GenericMethodExample {
        public T GenericMethod<T, T2>(T param1, T2 param2) {
            var isParam1Int = param1 is int;
            var isParam2Int = param2 is int;
            if (isParam1Int && isParam2Int) {
                var numberA = int.Parse(param1.ToString());
                var numberB = int.Parse(param2.ToString());

                return param1;
            }
            return param1;
        }

        // T should be a type of Person
        public T GenericMethodAdd<T, T2>(T param1, T2 param2) where T : Person {
            return param1;
        }

        // TClass should be a ref type means class and should have a constructor
        // K should be type of person
        public K GenericMethodAdd2<TClass, K>(TClass param1, K param2)
            where TClass : class, new()
            where K : Person {
            GenericMethodAdd3(3, new Person());
            return param2;
        }

        // TStruct should be a value type: int, datetime
        // K should be type of person
        public K GenericMethodAdd3<TStruct, K>(TStruct param1, K param2)
            where TStruct : struct
            where K : Person {
            GenericMethodAdd2(new Vector(), new Person());
            return param2;
        }
    }
}