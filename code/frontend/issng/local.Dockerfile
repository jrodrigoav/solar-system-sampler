FROM node:22.1.0 as build
WORKDIR /build
COPY package.json .
RUN npm install
COPY . .
RUN npm run builddocker
FROM nginx:1.26.0-alpine3.19
COPY --from=build /build/dist/issng/browser/ /usr/share/nginx/html
#COPY ../../../development_cert.pem /etc/nginx/certs/server.crt
#COPY ../../../development_cert.key /etc/nginx/certs/server.key
COPY local.conf /etc/nginx/conf.d/default.conf
EXPOSE 443
EXPOSE 80
CMD ["nginx", "-g", "daemon off;"]
