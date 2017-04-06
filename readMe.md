Author: Christina Pagger
Designer: Katharina Herzele

--Login--

--Position--

The Position Service starts with the PositionManager. It starts the GPS Service, after it succesfully got a connection,
it calls the getPlaceXML function from the PlaceDownload Script. This Script downloads the xml File from Google Places
and give it to the parsePlacesXML function from the PlaceParser Script witch reads through the xml File and creates a List
of Objects. This list is given to the startPOIinit function from the PositionPOI Script that instantiates different Prefabs
from the Objects in the List.