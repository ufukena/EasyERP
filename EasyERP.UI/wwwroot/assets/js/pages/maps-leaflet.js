"use strict";!function(){document.getElementById("basicMap")&&(e=L.map("basicMap").setView([42.35,-71.08],10),L.tileLayer("https://{s}.tile.osm.org/{z}/{x}/{y}.png",{attribution:'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a>',maxZoom:18}).addTo(e));var e=document.getElementById("shapeMap"),e=(e&&(e=L.map("shapeMap").setView([51.5,-.09],12),L.marker([51.5,-.09]).addTo(e),L.circle([51.508,-.11],{color:"red",fillColor:"#f03",fillOpacity:.5,radius:500}).addTo(e),L.polygon([[51.509,-.08],[51.503,-.06],[51.51,-.047]]).addTo(e),L.tileLayer("https://{s}.tile.osm.org/{z}/{x}/{y}.png",{attribution:'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a>',maxZoom:18}).addTo(e)),document.getElementById("dragMap"));if(e){e=L.map("dragMap").setView([48.817152,2.455],12);const r=L.marker([48.817152,2.455],{draggable:"true"}).addTo(e);r.bindPopup("<b>You're here!</b>").openPopup(),L.tileLayer("https://{s}.tile.osm.org/{z}/{x}/{y}.png",{attribution:'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a>',maxZoom:18}).addTo(e)}if(document.getElementById("userLocation")){const p=L.map("userLocation").setView([42.35,-71.08],10);p.locate({setView:!0,maxZoom:16}),p.on("locationfound",function(e){var o=e.accuracy;L.marker(e.latlng).addTo(p).bindPopup("You are somewhere around "+o+" meters from this point").openPopup(),L.circle(e.latlng,o).addTo(p)}),L.tileLayer("https://{s}.tile.osm.org/{z}/{x}/{y}.png",{attribution:'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a>',maxZoom:18}).addTo(p)}document.getElementById("customIcons")&&(e=L.map("customIcons").setView([51.5,-.09],10),o=L.icon({iconUrl:"assets/images/png/leaf-green.png",shadowUrl:"assets/images/png/leaf-shadow.png",iconSize:[38,95],shadowSize:[50,64],iconAnchor:[22,94],shadowAnchor:[4,62],popupAnchor:[-3,-76]}),t=L.icon({iconUrl:"assets/images/png/leaf-red.png",shadowUrl:"assets/images/png/leaf-shadow.png",iconSize:[38,95],shadowSize:[50,64],iconAnchor:[22,94],shadowAnchor:[4,62],popupAnchor:[-3,-76]}),a=L.icon({iconUrl:"assets/images/png/leaf-orange.png",shadowUrl:"assets/images/png/leaf-shadow.png",iconSize:[38,95],shadowSize:[50,64],iconAnchor:[22,94],shadowAnchor:[4,62],popupAnchor:[-3,-76]}),L.marker([51.5,-.09],{icon:t}).addTo(e),L.marker([51.4,-.51],{icon:o}).addTo(e),L.marker([51.49,-.45],{icon:a}).addTo(e),L.tileLayer("https://{s}.tile.osm.org/{z}/{x}/{y}.png",{attribution:'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a>',maxZoom:18}).addTo(e));var o,t=document.getElementById("layerControl"),a=(t&&(o=L.marker([39.61,-105.02]).bindPopup("This is Littleton, CO."),a=L.marker([39.74,-104.99]).bindPopup("This is Denver, CO."),e=L.marker([39.73,-104.8]).bindPopup("This is Aurora, CO."),t=L.marker([39.77,-105.23]).bindPopup("This is Golden, CO."),o=L.layerGroup([o,a,e,t]),a=L.tileLayer("https://{s}.tile.osm.org/{z}/{x}/{y}.png",{attribution:'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a>',maxZoom:18}),e=L.tileLayer("http://tile.stamen.com/watercolor/{z}/{x}/{y}.jpg",{attribution:'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a>',maxZoom:18}),t=L.map("layerControl",{center:[39.73,-104.99],zoom:10,layers:[a,o]}),L.control.layers({Street:a,Watercolor:e},{Cities:o}).addTo(t),L.tileLayer("https://c.tile.osm.org/{z}/{x}/{y}.png",{attribution:'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a>',maxZoom:18}).addTo(t)),document.getElementById("geoJson"));a&&(e=L.map("geoJson").setView([44.2669,-72.576],3),L.geoJson(statesData).addTo(e),L.geoJson(statesData,{style:function(e){return{fillColor:1e3<(e=e.properties.density)?"#800026":500<e?"#BD0026":200<e?"#E31A1C":100<e?"#FC4E2A":50<e?"#FD8D3C":20<e?"#FEB24C":10<e?"#FED976":"#FFEDA0",weight:2,opacity:1,color:"white",dashArray:"3",fillOpacity:.7}}}).addTo(e),L.tileLayer("https://{s}.tile.osm.org/{z}/{x}/{y}.png",{attribution:'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a>',maxZoom:18}).addTo(e))}();