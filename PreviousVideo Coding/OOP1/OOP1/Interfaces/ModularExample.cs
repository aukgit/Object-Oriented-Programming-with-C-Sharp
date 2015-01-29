using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Written by Alim Ul Karim
 * mailto: alim@developers-organism.com
 * developers-organism.com
 * find us on fb.com/developersOrganism
 * */
namespace OOP1.Interfaces {
    public class ModularExample : ISavable, IDelete, ICounter {
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
    }
}
