using System;
/*
 * Written by Alim Ul Karim
 * mailto: alim@developers-organism.com
 * developers-organism.com
 * find us on fb.com/developersOrganism
 * */
namespace OOP1.Interfaces {
    public class ModularExample3 : OOP1.Interfaces.ISavable, OOP1.Interfaces.IDelete, OOP1.Interfaces.ICounter, OOP1.Interfaces.IAdditionalSavable, OOP1.INewInterface {
        #region ISavable Members

        public int Changes {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public void Save() {
            throw new NotImplementedException();
        }

        #endregion

        #region IDelete Members

        public int Deleted {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public void Delete() {
            throw new NotImplementedException();
        }

        #endregion

        #region ICounter Members

        public void UpdateCounterChanges() {
            throw new NotImplementedException();
        }

        public void UpdateCounterDeleted() {
            throw new NotImplementedException();
        }

        #endregion

        #region IAdditionalSavable Members

        string Interfaces.IAdditionalSavable.Save() {
            throw new NotImplementedException();
        }

        #endregion

        #region INewInterface Members

        public void NewMethod() {
            throw new NotImplementedException();
        }

        #endregion
    }
}
